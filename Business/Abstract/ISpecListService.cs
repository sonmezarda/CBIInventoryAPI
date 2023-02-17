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
    public interface ISpecListService
    {
        //DataResult<List<SpecWithName>> GetAllWithNames();
        DataResult<List<SpecList>> GetAll();
        //DataResult<List<SpecWithName>> GetByProductId(int id);
        DataResult<SpecList> Add(SpecList spec);
        Result Update(SpecList spec);
        Result Delete(int id);
    }
}
