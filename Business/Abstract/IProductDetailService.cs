using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductDetailService
    {
        DataResult<List<ProductDetail>> GetAll();
        DataResult<ProductDetail> GetById(int id);
        Result Add(ProductDetail product);
        Result Update(ProductDetail product);
        Result Delete(ProductDetail product);
    }
}
