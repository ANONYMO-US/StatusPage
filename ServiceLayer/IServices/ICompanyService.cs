using TaskmanagementApi.DataLayer.Class.GenericClass;

namespace TaskmanagementApi.ServiceLayer.IServices
{
    public interface ICompanyService
    {
        public bool CreateService(GenericCompanyServices CompanyService);
        public IEnumerable<GenericCompanyServices> GetAllServices();
        public bool UpdateService(GenericCompanyServices CompanyService);
        public bool DeleteService(int ServiceId);
    }
}
