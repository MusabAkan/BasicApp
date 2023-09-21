using BasicApp.Bussiness.Abstract;
using BasicApp.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace BasicApp.Web.ViewComponents
{
    public class CategoryListViewComponent: ViewComponent
    {
        readonly ICategoryService _categoryService;

        public CategoryListViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public ViewViewComponentResult Invoke()
        {
            var model = new CategoryListViewModel()
            {
                Categories = _categoryService.GetAll(),
                CurrentCategory = int.TryParse(HttpContext.Request.Query["category"], out int result) ? result : 0
            };
            return View(model);
        }
    }
}
