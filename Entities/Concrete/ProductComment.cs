using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class ProductComment : IEntity
    {
        public string Author { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
    }
}
