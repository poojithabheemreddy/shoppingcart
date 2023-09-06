using shoppingapplication.Models;

namespace shoppingapplication.Repositories
{
    public interface ILoginRepository
    {
        loginmodel RepositoryGetUserDetails(loginmodel login);
    }
}
