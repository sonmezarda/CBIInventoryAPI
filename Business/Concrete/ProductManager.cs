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
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
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
            return new SuccessDataResult<ProductWithDetail>(_productDal.GetWithDetailById(id));
        }

        DataResult<Product> IProductService.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}