using TaskmanagementApi.DataLayer.Class.GenericClass;

namespace TaskmanagementApi.BusinessLayer.IRepository
{
    public interface IUserRepository
    {
        public GenericUser CreateUser(GenericUser newUser);
        public bool IsUserPresent(int userId);
    }
}
