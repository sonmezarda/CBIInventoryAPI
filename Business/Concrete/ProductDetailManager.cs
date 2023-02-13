using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductDetailManager : IProductDetailService
    {
        private readonly IProductDetailDal _productDetailDal;
        public ProductDetailManager(IProductDetailDal productDetailDal)
        {
            _productDetailDal = productDetailDal;
        }
        public Result Add(ProductDetail product)
        {
            throw new NotImplementedException();
        }

        public Result Delete(ProductDetail product)
        {
            throw new NotImplementedException();
        }

        public DataResult<List<ProductDetail>> GetAll()
        {
            return new SuccessDataResult<List<ProductDetail>>(_productDetailDal.GetAll());
        }

        public DataResult<ProductDetail> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Result Update(ProductDetail product)
        {
            throw new NotImplementedException();
        }
    }
}
