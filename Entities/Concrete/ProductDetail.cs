using Core.Entities.Abstract;
using Entities.DTOs;

namespace Entities.Concrete
{
    public class ProductDetail : IEntity
    {
        public List<ProductComment>? Comments { get; set; }
        public List<SpecWithName>? Specs { get; set; }
    }
}
