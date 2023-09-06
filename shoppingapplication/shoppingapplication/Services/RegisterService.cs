using shoppingapplication.Models;
using shoppingapplication.Repositories;
namespace shoppingapplication.Services
{
    public class RegisterService:IRegisterService
    {
        private readonly IRegisterRepository _repository;
        public RegisterService(IRegisterRepository registerrepo)
        {
            _repository = registerrepo;
        }
        public int ServiceInsertUser(loginmodel model)
        {
            return _repository.RepositoryInsertUser(model);
        }
    }
}
