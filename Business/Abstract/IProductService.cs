using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IProductService
    {
        DataResult<List<ProductWithNamesDto>> GetAllWithNames();
        DataResult<List<Product>> GetByCategoryId(int categoryId);
        DataResult<Product> GetById(int id);
        Result Add(Product product);
        Result Update(Product product);
        Result Delete(Product product);
    }
}