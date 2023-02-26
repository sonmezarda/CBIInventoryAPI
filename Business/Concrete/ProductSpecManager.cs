using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductSpecManager : IProductSpecService
    {
        private readonly IProductSpecsDal _productSpecsDal;
        private readonly ISpecListDal _specListDal;
        private readonly ISpecDal _specDal;
        public ProductSpecManager(IProductSpecsDal productSpecsDal, ISpecListDal specListDal, ISpecDal specDal)
        {
            _productSpecsDal = productSpecsDal;
            _specListDal = specListDal;
            _specDal = specDal;
        }
        public DataResult<ProductSpecWithObjectDto> Add(ProductSpecWithValueDto entity)
        {
            var spec = new Spec
            {
                SpecId = entity.SpecId,
                Value = entity.SpecValue
            };
            spec = _specDal.Add(spec);

            var productSpec = new ProductSpec
            {
                ProductId = entity.ProductId,
                SpecId = spec.Id
            };
            productSpec = _productSpecsDal.Add(productSpec);

            var specList = _specListDal.Get(sl => sl.Id == entity.SpecId);
            var productSpecWithObject = new ProductSpecWithObjectDto
            {
                Id = productSpec.Id,
                ProductId = productSpec.ProductId,
                Spec = specList,
                SpecValue = entity.SpecValue
            };

            return new SuccessDataResult<ProductSpecWithObjectDto>(productSpecWithObject);
        }

        public Result Delete(int id)
        {
            var productSpec = _productSpecsDal.Get(ps => ps.Id == id);
            _productSpecsDal.Delete(productSpec);

            var spec = _specDal.Get(s => s.Id == id);
            _specDal.Delete(spec);

            return new SuccessResult();
        }

        public DataResult<List<ProductSpecWithObjectDto>> GetAllWithObj()
        {
            return new SuccessDataResult<List<ProductSpecWithObjectDto>>(_productSpecsDal.GetAllWithObj());
        }

        public DataResult<List<ProductSpecWithObjectDto>> GetByProductIdWithObj(int productId)
        {
            return new SuccessDataResult<List<ProductSpecWithObjectDto>>(_productSpecsDal.GetAllWithObj(p=> p.ProductId == productId));
        }
    }
}
