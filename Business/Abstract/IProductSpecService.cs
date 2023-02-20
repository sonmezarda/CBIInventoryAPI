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
        DataResult<List<ProductSpecWithNamesDto>> GetAllWithNames();
        DataResult<List<ProductSpec>> GetAll();
        DataResult<ProductSpecWithNamesDto> GetByProductId(int id);
        DataResult<ProductSpec> Add(ProductSpec spec);
        Result Update(ProductSpec spec);
        Result Delete(int id);
    }
}
