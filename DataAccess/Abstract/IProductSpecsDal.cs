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
    public interface IProductSpecsDal : IEntityRepository<ProductSpec>
    {
        public List<ProductSpecWithObjectDto> GetAllWithObj(Expression<Func<ProductSpecWithObjectDto, bool>>? filter = null);

    }
}
