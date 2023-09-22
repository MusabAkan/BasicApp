using BasicApp.Bussiness.Abstract;
using BasicApp.Entities.Concrete;
using BasicApp.Web.Models;
using BasicApp.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace BasicApp.Web.Controllers
{
    public class CartController : Controller
    {
        readonly ICartSessionService _cartSessionService;
        readonly ICartService _cartService;
        readonly IProductService _productService;

        public CartController(ICartSessionService cartSessionService, ICartService cartService, IProductService productService)
        {
            _cartSessionService = cartSessionService;
            _cartService = cartService;
            _productService = productService;
        }

        public ActionResult AddToCart(int productId)
        {
            var productToBeAdded = _productService.GetById(productId);
            var cart = _cartSessionService.GetCart();
            _cartService.AddToCart(cart, productToBeAdded);
            _cartSessionService.SetCart(cart);
            TempData.Add("message", $"Your product, {productToBeAdded.ProductName} was successfuly added to the cart!");
            return RedirectToAction("Index", "Product");
        }

        public ViewResult List()
        {
            Cart cart = _cartSessionService.GetCart();
            CartListViewModel model = new ()
            {
                Cart = cart
            };
            return View(model);
        }
    }
}
