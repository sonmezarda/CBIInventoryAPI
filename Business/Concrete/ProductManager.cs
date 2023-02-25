using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.DataAccess.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;
        private readonly IProductSpecsDal _productSpecDal;
        private readonly IProductCommentDal _commentDal;
        public ProductManager(IProductDal productDal, IProductSpecsDal productSpecs, IProductCommentDal commentDal)
        {
            _productDal = productDal;
            _productSpecDal = productSpecs;
            _commentDal = commentDal;
        }

        public DataResult<List<ProductWithObjectsDto>> GetAllWithNames()
        {
            return new SuccessDataResult<List<ProductWithObjectsDto>>(_productDal.GetAll());
        }

        public DataResult<List<Product>> GetByCategoryId(int categoryId)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == categoryId));
        }

        public DataResult<ProductWithObjectsDto> GetByIdWithNames(int id)
        {
            return new SuccessDataResult<ProductWithObjectsDto>(_productDal.Get(p => p.Id == id));
        }

        public DataResult<Product> Add(Product product)
        {
            return new SuccessDataResult<Product>(_productDal.Add(product));
   
        }

        public Result Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult();
        }

        public Result Delete(int id)
        {
            EfEntityRepository<Product, InventoryContext> repository = new EfEntityRepository<Product, InventoryContext>();
            var product = repository.Get(p => p.Id == id);
            _productDal.Delete(product);
            return new SuccessResult();
        }

        public DataResult<ProductWithDetail> GetWithDetailById(int id)
        {
            var product = _productDal.Get(p => p.Id == id);
            var specs = _productSpecDal.GetAllWithObj(ps => ps.ProductId == id);
            var comments = _commentDal.GetAll(c => c.ProductId == id);
            var productDetail = new ProductDetail
            {
                Specs = specs,
                Comments = comments
            };
            var productWithDetail = new ProductWithDetail
            {
                Product = product,
                ProductDetail = productDetail
            };
            return new SuccessDataResult<ProductWithDetail>(productWithDetail);
        }

        DataResult<Product> IProductService.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}