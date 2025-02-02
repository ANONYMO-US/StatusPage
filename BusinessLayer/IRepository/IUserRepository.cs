using TaskmanagementApi.DataLayer.Class;
using TaskmanagementApi.DataLayer.Class.GenericClass;

namespace TaskmanagementApi.BusinessLayer.IRepository
{
    public interface IUserRepository
    {
        public bool CreateUser(User newUser);
        public bool IsUserPresent(int userId);
    }
}
