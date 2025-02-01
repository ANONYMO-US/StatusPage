using TaskmanagementApi.BusinessLayer.IRepository;
using TaskmanagementApi.DataLayer.Class.GenericClass;

namespace TaskmanagementApi.BusinessLayer.Repository
{
    public class UserRepository : IUserRepository
    {
        public GenericUser CreateUser(GenericUser newUser)
        {
            return new GenericUser();
        }
        public bool IsUserPresent(int UserId)
        {
            return true;
        }
    }
}
