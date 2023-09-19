using BasicApp.Bussiness.Abstract;
using BasicApp.DataAccess.Abstract;
using BasicApp.Entities.Concrete;

namespace BasicApp.Bussiness.Concrete
{
    public class CategoryManager : ICategoryService
    {
        readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal) => _categoryDal = categoryDal;

        public List<Category> GetAll() => _categoryDal.GetList();
    }
}
