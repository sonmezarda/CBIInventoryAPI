using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public DataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
        }

        public DataResult<Category> GetById(int id)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(p => p.Id == id));
        }

        public Result Add(Category category)
        {
            _categoryDal.Add(category);
            return new SuccessResult();
        }

        public Result Update(Category category)
        {
            _categoryDal.Update(category);
            return new SuccessResult();
        }

        public Result Delete(Category category)
        {
            _categoryDal.Delete(category);
            return new SuccessResult();
        }
    }
}