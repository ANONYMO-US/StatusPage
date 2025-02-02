using TaskmanagementApi.DataLayer.Class;
using TaskmanagementApi.DataLayer.Class.GenericClass;

namespace TaskmanagementApi.ServiceLayer.IServices
{
    public interface ICompanyService
    {
        public bool CreateService(CompanyServices CompanyService);
        public IEnumerable<CompanyServices> GetAllServices();
        public bool UpdateService(CompanyServices CompanyService);
        public bool DeleteService(int ServiceId);
    }
}
