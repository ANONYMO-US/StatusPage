using TaskmanagementApi.BusinessLayer.IRepository;
using TaskmanagementApi.DataLayer.Class.GenericClass;

namespace TaskmanagementApi.BusinessLayer.Repository
{
    public class CompanyServiceRepository : ICompanyServiceRepository
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
