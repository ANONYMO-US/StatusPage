using TaskmanagementApi.DataLayer.Class;
using TaskmanagementApi.DataLayer.Class.GenericClass;

namespace TaskmanagementApi.ServiceLayer.IServices
{
    public interface ILoginService
    {
        public bool CreateUser(User newUser);
        public bool IsUserPresent(int userId);
    }
}
