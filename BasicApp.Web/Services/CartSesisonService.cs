using BasicApp.Entities.Concrete;
using BasicApp.Web.ExtensionMethods;

namespace BasicApp.Web.Services
{
    public class CartSesisonService : ICartSessionService
    {
        private IHttpContextAccessor _httpContextAccessor;

        public CartSesisonService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public Cart GetCart()
        {
            Cart cartToCheck = _httpContextAccessor.HttpContext.Session.GetObject<Cart>("cart");
            if (cartToCheck == null)
            {
                _httpContextAccessor.HttpContext.Session.SetObject("cart", new Cart());
                cartToCheck = _httpContextAccessor.HttpContext.Session.GetObject<Cart>("cart");
            }
            return cartToCheck;
        }

        public void SetCart(Cart cart)
        {
           _httpContextAccessor.HttpContext.Session.SetObject("cart", cart);
        }
    }
}
