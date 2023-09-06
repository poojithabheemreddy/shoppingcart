using shoppingapplication.Models;

namespace shoppingapplication.Services
{
    public interface ILoginService
    {
        loginmodel ServiceGetUserDetails(loginmodel login);
    }
}
