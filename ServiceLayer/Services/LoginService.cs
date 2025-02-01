using TaskmanagementApi.DataLayer.Class.GenericClass;
using TaskmanagementApi.ServiceLayer.IServices;

namespace TaskmanagementApi.ServiceLayer.Services
{
    public class LoginService : ILoginService
    {
        public GenericUser CreateUser()
        {
            return new GenericUser();
        }
        public bool IsUserPresent()
        {
            return true;
        }
    }
}
