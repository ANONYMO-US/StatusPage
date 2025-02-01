using TaskmanagementApi.DataLayer.Class.GenericClass;

namespace TaskmanagementApi.ServiceLayer.IServices
{
    public interface ILoginService
    {
        public GenericUser CreateUser();
        public bool IsUserPresent();
    }
}
