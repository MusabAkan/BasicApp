using BasicApp.Bussiness.Abstract;
using BasicApp.Entities.Concrete;

namespace BasicApp.Bussiness.Concrete
{
    public class CartManager : ICartService
    {
        public void AddToCart(Cart cart, Product product)
        {
            CartLine cartLine = cart.CartLines.FirstOrDefault(c => c.Product.ProductID == product.ProductID);
            if (cartLine != null)
            {
                cartLine.Qunatity++;
                return;
            }
            cart.CartLines.Add(new () { Product = product, Qunatity = 1 });
        }

        public void RemoveFromCart(Cart cart, int productId)
        {
            cart.CartLines.Remove(cart.CartLines.FirstOrDefault(c => c.Product.ProductID == productId));
        }

        public List<CartLine> List(Cart cart)
        {
            return cart.CartLines;
        }
    }
}
