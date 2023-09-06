using shoppingapplication.Repositories;
namespace shoppingapplication.Services
{
    public class CategoryService:ICategoryService
    {
        private readonly ICategoryRepository _categoryRepo;
        public CategoryService(ICategoryRepository categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }
        public int ServiceInsertCategory(int categoryName, string categoryDesc)
        {
            return _categoryRepo.RepoInsertCategory(categoryName, categoryDesc);
        }
    }
}
