using shoppingapplication.Models;
using shoppingapplication.Repositories;

namespace shoppingapplication.Services
{
    public class LoginService:ILoginService
    {
        private readonly ILoginRepository _repository;        //object creation
        public LoginService(ILoginRepository loginrepo)      //injection
        {
            _repository = loginrepo;
        }
        public loginmodel ServiceGetUserDetails(loginmodel login)
        {
            return _repository.RepositoryGetUserDetails(login);
        }
    }
}
