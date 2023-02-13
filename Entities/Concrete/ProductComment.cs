using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class ProductComment : IEntity
    {
        public int Id { get; set; }
        public string? Author { get; set; }
        public string? Description { get; set; }
        public DateTime? Date { get; set; }
        public int ProductId { get; set; }
    }
}
