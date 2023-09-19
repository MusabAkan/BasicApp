using BasicApp.Core.DataAccess;
using BasicApp.Entities.Concrete;

namespace BasicApp.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product> { }
   
}
