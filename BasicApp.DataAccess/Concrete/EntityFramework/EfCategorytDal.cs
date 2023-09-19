using BasicApp.Core.DataAccess.EntityFramework;
using BasicApp.DataAccess.Abstract;
using BasicApp.Entities.Concrete;

namespace BasicApp.DataAccess.Concrete.EntityFramework
{
     
    public class EfCategoryDal : EfEntityRepositoryBase<Category, AppDbContext>, ICategoryDal
    {

    }
}
