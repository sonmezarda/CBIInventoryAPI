using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BoxManager : IBoxService
    {
        private readonly IBoxDal _boxDal;

        public BoxManager(IBoxDal boxDal)
        {
            _boxDal = boxDal;
        }
        public DataResult<List<Box>> GetAll()
        {
            return new SuccessDataResult<List<Box>>(_boxDal.GetAll());
        }

        public DataResult<Box> GetById(int id)
        {
            return new SuccessDataResult<Box>(_boxDal.Get(p => p.Id == id));
        }

        public DataResult<Box> Add(Box box)
        {
            return new SuccessDataResult<Box>(_boxDal.Add(box));
        }

        public Result Update(Box box)
        {
            _boxDal.Update(box);
            return new SuccessResult();
        }

        public Result Delete(int id)
        {
            var entity = _boxDal.Get(p =>p.Id == id);
            _boxDal.Delete(entity);
            return new SuccessResult();
        }
    }
}
