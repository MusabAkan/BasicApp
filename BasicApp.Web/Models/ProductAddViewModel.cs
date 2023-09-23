using BasicApp.Entities.Concrete;

namespace BasicApp.Web.Models
{
    public class ProductAddViewModel
    {
        public List<Category> Categories { get; set; } = new List<Category>();
        public Product Product { get; set; }
    }
}
