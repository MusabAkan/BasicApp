using BasicApp.Entities.Concrete;

namespace BasicApp.Web.Models
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; set; }
        public int CurrentCategory { get; set; }
    }
}
