using TaskmanagementApi.BusinessLayer.IRepository;
using TaskmanagementApi.DataLayer.Class;
using TaskmanagementApi.DataLayer.Class.GenericClass;
using TaskmanagementApi.DataLayer.DataBaseContexts;

namespace TaskmanagementApi.BusinessLayer.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserDbContext _context = new UserDbContext();
        public bool CreateUser(User newUser)
        {
            _context.Add(newUser);
            _context.SaveChanges();
            return true;
        }
        public bool IsUserPresent(int Userid)
        {
            var user = _context.ListofUsers.Where(b => b.UserId == Userid); 
            if(user.Count() == 0) {return false; }
            else { return true; }
        }
    }
}
