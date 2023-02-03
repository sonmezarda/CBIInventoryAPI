using System.Linq.Expressions;
using Core.DataAccess.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using FireSharp.Config;
using FireSharp.Interfaces;

namespace DataAccess.Concrete.FireBase
{
    public class FBProductDetailDal : FBEntityRepository<ProductDetail, ProductDetailConfig>, IProductDetailDal    
    {

    }
}
