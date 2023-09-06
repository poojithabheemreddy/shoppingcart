namespace shoppingapplication.Repositories
{
    public interface ICategoryRepository
    {
        int RepoInsertCategory(int categoryName, string categoryDesc);
    }
}
