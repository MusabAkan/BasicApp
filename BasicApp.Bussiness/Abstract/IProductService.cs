using BasicApp.Entities.Concrete;

namespace BasicApp.Bussiness.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByCategory(string categoryId);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);

    }
}
