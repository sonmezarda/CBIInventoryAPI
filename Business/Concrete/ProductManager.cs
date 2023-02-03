﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
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

        public DataResult<List<ProductWithNamesDto>> GetAllWithNames()
        {
            return new SuccessDataResult<List<ProductWithNamesDto>>(_productDal.GetAll());
        }

        public DataResult<List<Product>> GetByCategoryId(int categoryId)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == categoryId));
        }

        public DataResult<Product> GetById(int id)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.Id == id));
        }

        public Result Add(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult();
        }

        public Result Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult();
        }

        public Result Delete(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult();
        }
    }
}