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
    public interface IProductSpecService
    {
        DataResult<List<ProductSpecWithObjectDto>> GetAllWithObj();
        DataResult<List<ProductSpecWithObjectDto>> GetByProductIdWithObj(int productId);
        DataResult<ProductSpecWithValueDto> Add(ProductSpecWithValueDto entity);
        Result Delete(int id);
    }
}
