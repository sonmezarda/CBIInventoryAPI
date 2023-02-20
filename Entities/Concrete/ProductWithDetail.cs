using Core.Entities.Abstract;
using Entities.DTOs;

namespace Entities.Concrete
{
    public class ProductWithDetail : IEntity
    {
        public ProductWithObjectsDto Product { get; set; }
        public ProductDetail ProductDetail { get; set; }
    }
}
