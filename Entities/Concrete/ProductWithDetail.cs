using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class ProductWithDetail : IEntity
    {
        public Product Product { get; set; }
        public ProductDetail ProductDetail { get; set; }
    }
}
