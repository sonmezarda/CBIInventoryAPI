using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBoxService
    {
        DataResult<List<Box>> GetAll();
        DataResult<Box> GetById(int id);
        DataResult<Box> Add(Box box);
        Result Update(Box box);
        Result Delete(int id);
    }
}