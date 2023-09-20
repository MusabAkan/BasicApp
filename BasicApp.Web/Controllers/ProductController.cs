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

        public IActionResult Index()
        {
            var product = _productService.GetAll();
            ProductListViewModel model = new ()
            {
                Products = product
            };
            return View(model);
        }
    }
}
