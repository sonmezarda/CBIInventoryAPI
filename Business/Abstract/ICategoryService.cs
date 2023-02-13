using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        DataResult<List<Category>> GetAll();
        DataResult<Category> GetById(int id);
        DataResult<Category> Add(Category category);
        Result Update(Category category);
        Result Delete(int id);
    }
}