using TaskmanagementApi.DataLayer.Class.GenericClass;
using TaskmanagementApi.ServiceLayer.IServices;

namespace TaskmanagementApi.ServiceLayer.Services
{
    public class CompanyService : ICompanyService
    {
        public bool CreateService(GenericCompanyServices CompanyService)
        {
            return true;
        }
        public IEnumerable<GenericCompanyServices> GetAllServices()
        {
            return new List<GenericCompanyServices>();
        }
        public bool UpdateService(GenericCompanyServices CompanyService)
        {
            return true;
        }
        public bool DeleteService(int ServiceId)
        {
            return true;
        }
    }
}
