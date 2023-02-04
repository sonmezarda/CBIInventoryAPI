using Core.Entities.Abstract;
using Entities.DTOs;

namespace Entities.Concrete
{
    public class ProductWithDetail : IEntity
    {
        public ProductWithNamesDto Product { get; set; }
        public ProductDetail ProductDetail { get; set; }
    }
}
