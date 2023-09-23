using BasicApp.Entities.Concrete;

namespace BasicApp.Web.Models
{
    public class ProductUpdateViewModel
    {
        public List<Category> Categories { get; set; }
        public Product Product { get; set; }
    }
}
