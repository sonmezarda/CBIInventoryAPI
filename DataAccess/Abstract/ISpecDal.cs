using Core.DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ISpecDal : IEntityRepository<Spec>
    {
        public SpecWithName Get(Expression<Func<SpecWithName, bool>>? filter = null);
        public List<SpecWithName> GetAllWithNames(Expression<Func<SpecWithName, bool>>? filter = null);
        public List<SpecWithName> GetByProductId(int id);

    }
}
