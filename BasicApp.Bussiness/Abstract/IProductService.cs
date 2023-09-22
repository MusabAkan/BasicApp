using BasicApp.Entities.Concrete;

namespace BasicApp.Bussiness.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByCategory(int categoryId);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        Product GetById(int productId);

    }
}
