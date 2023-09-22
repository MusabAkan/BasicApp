using BasicApp.Entities.Concrete;

namespace BasicApp.Web.Services
{
    public interface ICartSessionService
    {
        Cart GetCart();
        void SetCart(Cart cart);
    }
}
