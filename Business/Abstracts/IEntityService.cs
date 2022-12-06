using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IEntityService<T>
    {
        public Task<List<T>> Get(Expression<Func<T, bool>> filter=null);
        public Task<T> GetByID(int id);
        public Task<T> Add(T item);
        public Task<bool> Delete(int id);
        public Task<T> Update(T item);
    }
}
