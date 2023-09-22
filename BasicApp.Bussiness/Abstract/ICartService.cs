using BasicApp.Entities.Concrete;

namespace BasicApp.Bussiness.Abstract
{
    public interface ICartService
    {
        void AddToCart(Cart cart, Product product);
        void RemoveFromCart(Cart cart, int ProductId);
        List<CartLine> List(Cart cart);

    }
}
