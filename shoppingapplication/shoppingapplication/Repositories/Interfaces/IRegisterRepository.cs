using shoppingapplication.Models;
namespace shoppingapplication.Repositories
{
    public interface IRegisterRepository
    {
        int RepositoryInsertUser(loginmodel user);
    }
}
