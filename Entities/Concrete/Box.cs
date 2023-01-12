using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Box: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
