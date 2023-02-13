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
        List<SpecWithName> GetByProductId(int id);
        List<SpecWithName> GetAll(Expression<Func<SpecWithName, bool>>? filter = null);
        SpecWithName Get(Expression<Func<SpecWithName, bool>>? filter=null);
    }
}
