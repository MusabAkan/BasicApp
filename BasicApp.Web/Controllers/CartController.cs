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

        public ActionResult List()
        {
            var cart = _cartSessionService.GetCart();
            CartListViewModel cartListViewModel = new CartListViewModel
            {
                Cart = cart
            };
            return View(cartListViewModel);
        }

        public ActionResult Remove(int productId)
        {
            var cart = _cartSessionService.GetCart();
            _cartService.RemoveFromCart(cart, productId);
            _cartSessionService.SetCart(cart);
            TempData.Add("message", $"Your product was successfully removed form the cart!");
            return RedirectToAction("List");

        }

        public IActionResult Complete()
        {
            var shippingDetailsViewModel = new ShiippingDetailsViewModel()
            {
                ShippingDetails = new ShiippingDetails()
            };
            return View(shippingDetailsViewModel);
        }
        [HttpPost]
        public IActionResult Complete(ShiippingDetails shippingDetails)
        {
            if (!ModelState.IsValid)
                return View();
            TempData.Add("message", $"Thank you {shippingDetails.FirstName}, your order is in process!");
            return View();


        }
    }

     
}
