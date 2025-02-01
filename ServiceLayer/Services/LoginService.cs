using TaskmanagementApi.BusinessLayer.IRepository;
using TaskmanagementApi.DataLayer.Class.GenericClass;
using TaskmanagementApi.ServiceLayer.IServices;

namespace TaskmanagementApi.ServiceLayer.Services
{
    public class LoginService : ILoginService
    {
        public IUserRepository IUserRepository { get; set; }
        public LoginService(IUserRepository userRepository)
        {
            IUserRepository = userRepository;
        }
        public GenericUser CreateUser(GenericUser newUser)
        {
            return IUserRepository.CreateUser(newUser);
        }
        public bool IsUserPresent(int UserId)
        {
            return IUserRepository.IsUserPresent(UserId);
        }
    }
}
