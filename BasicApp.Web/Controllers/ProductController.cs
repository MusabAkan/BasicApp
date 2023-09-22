using BasicApp.Bussiness.Abstract;
using BasicApp.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicApp.Web.Controllers
{
    public class ProductController : Controller
    {
        readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index(int page = 1, int category = 0)
        {
            int pageSize = 5;
            var product = _productService.GetByCategory(category);
            ProductListViewModel model = new()
            {
                Products = product.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                PageCount = (int)Math.Ceiling(product.Count / (double)pageSize),
                PageSize = pageSize,
                CurrentCategory = category,
                CurrentPage = page
            };
            return View(model);
        }
    }
}
