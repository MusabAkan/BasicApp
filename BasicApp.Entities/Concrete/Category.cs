using BasicApp.Core.Entities;

namespace BasicApp.Entities.Concrete
{
    public class Category :IEntity
    {
         public string Name { get; set; }
         public Guid Id { get; set; }
    }
}
