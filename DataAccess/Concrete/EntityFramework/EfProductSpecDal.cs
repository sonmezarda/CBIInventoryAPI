using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductSpecDal : EfEntityRepository<ProductSpec, InventoryContext>, IProductSpecsDal
    {
        public List<ProductSpecWithObjectDto> GetAllWithObj(Expression<Func<ProductSpecWithObjectDto, bool>>? filter = null)
        {
            using (InventoryContext context = new InventoryContext())
            {
                var result = from ps in context.ProductSpecs
                             join p in context.Products
                                 on ps.ProductId equals p.Id
                             join s in context.Specs
                                 on ps.SpecId equals s.Id
                             join sl in context.SpecList
                              on s.SpecId equals sl.Id

                             select new ProductSpecWithObjectDto
                             {
                                 Id = ps.Id,
                                 Spec = sl,
                                 SpecValue = s.Value,
                                 ProductId= p.Id,
                             };

                if (filter != null)
                {
                    return result.Where(filter).ToList();
                }
                else
                {
                    return result.ToList();
                }
            }
        }
    }
}
