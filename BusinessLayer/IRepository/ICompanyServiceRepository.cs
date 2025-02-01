using TaskmanagementApi.DataLayer.Class.GenericClass;

namespace TaskmanagementApi.BusinessLayer.IRepository
{
    public interface ICompanyServiceRepository
    {
        public bool CreateService(GenericCompanyServices CompanyService);
        public IEnumerable<GenericCompanyServices> GetAllServices();
        public bool UpdateService(GenericCompanyServices CompanyService);
        public bool DeleteService(int ServiceId);
    }
}
