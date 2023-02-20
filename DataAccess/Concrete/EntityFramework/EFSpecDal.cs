using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFSpecDal : EfEntityRepository<Spec, InventoryContext>, ISpecDal
    {
        /*
        public List<SpecWithName> GetAllWithNames(Expression<Func<SpecWithName, bool>>? filter = null)
        {
            
            using (InventoryContext context = new InventoryContext())
            {
                var result = from ps in context.ProductSpecs
                             join s in context.Specs
                             on ps.SpecId equals s.SpecId
                             join sl in context.SpecList
                             on s.SpecId equals sl.Id
                             select new SpecWithName
                             {
                                 Id = s.Id,
                                 SpecName = sl.Name,
                                 Value = s.Value
                             };

                if (filter == null)
                {
                    return result.Where(filter).ToList();
                }
                else
                {
                    return result.ToList();
                }
                
            }
        }
        public List<SpecWithName> GetByProductId(int id)
        {
            using (InventoryContext context = new InventoryContext())
            {
                var result = from ps in context.ProductSpecs
                             join s in context.Specs
                             on ps.SpecId equals s.SpecId
                             join sl in context.SpecList
                             on s.SpecId equals sl.Id
                             where ps.ProductId == id
                             select new SpecWithName
                             {
                                 Id = s.Id,
                                 SpecName = sl.Name,
                                 Value = s.Value
                             };
                return result.ToList();
            }
        }*/
    }
}
