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
    public class SpecListManager : ISpecListService
    {
        private readonly ISpecListDal _specListDal;
        public SpecListManager(ISpecListDal specListDal)
        {
            _specListDal= specListDal;
        }
        public DataResult<SpecList> Add(SpecList spec)
        {
            return new SuccessDataResult<SpecList>(_specListDal.Add(spec));
        }

        public Result Delete(int id)
        {
            var entity = _specListDal.Get(s => s.Id == id);
            _specListDal.Delete(entity);
            return new SuccessResult();
        }

        public DataResult<List<SpecList>> GetAll()
        {
            return new SuccessDataResult<List<SpecList>>(_specListDal.GetAll());
        }

        public Result Update(SpecList spec)
        {
            _specListDal.Update(spec);
            return new SuccessResult();
        }
    }
}
