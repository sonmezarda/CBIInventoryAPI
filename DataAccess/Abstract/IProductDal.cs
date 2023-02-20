using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductWithObjectsDto> GetAll(Expression<Func<ProductWithObjectsDto, bool>>? filter = null);
        ProductWithObjectsDto Get(Expression<Func<ProductWithObjectsDto, bool>>? filter = null);
        public ProductWithDetail GetWithDetailById(int id);

    }
}
