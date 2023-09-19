using BasicApp.Core.DataAccess.EntityFramework;
using BasicApp.DataAccess.Abstract;
using BasicApp.Entities.Concrete;

namespace BasicApp.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, AppDbContext>, IProductDal
    {

    }
 
}
