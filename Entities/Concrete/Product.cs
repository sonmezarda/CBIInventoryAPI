using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int StockCount { get; set; }
        public int BoxId { get; set; }
        public string Image { get; set; }

    }
}
