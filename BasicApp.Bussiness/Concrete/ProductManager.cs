using BasicApp.Bussiness.Abstract;
using BasicApp.DataAccess.Abstract;
using BasicApp.DataAccess.Concrete.EntityFramework;
using BasicApp.Entities.Concrete;

namespace BasicApp.Bussiness.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;
        public ProductManager(IProductDal productDal) => _productDal = productDal;
        public List<Product> GetAll() => _productDal.GetList();
        public List<Product> GetByCategory(int categoryId) => _productDal.GetList(p => p.CategoryID == categoryId);
        public void Add(Product product) => _productDal.Add(product);
        public void Update(Product product) => _productDal.Update(product);
        public void Delete(Product product) => _productDal.Delete(product);
    }
}
