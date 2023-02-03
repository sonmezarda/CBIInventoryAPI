using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class ProductDetail : IEntity
    {
        public int ProductId { get; set; }
        public Dictionary<string, ProductComment>? Comments { get; set; }
        public Dictionary<string,string>? Specs { get; set; }
    }
}
