using TaskmanagementApi.BusinessLayer.IRepository;
using TaskmanagementApi.DataLayer.Class;
using TaskmanagementApi.DataLayer.Class.GenericClass;
using TaskmanagementApi.ServiceLayer.IServices;

namespace TaskmanagementApi.ServiceLayer.Services
{
    public class CompanyService : ICompanyService
    {
        public ICompanyServiceRepository CompanyServiceRepository { get; set; }
        public CompanyService(ICompanyServiceRepository companyServiceRepository) 
        { 
            CompanyServiceRepository = companyServiceRepository;
        }
        public bool CreateService(CompanyServices CompanyService)
        {
            return CompanyServiceRepository.CreateService(CompanyService);
        }
        public IEnumerable<CompanyServices> GetAllServices()
        {
            return CompanyServiceRepository.GetAllServices();
        }
        public bool UpdateService(CompanyServices CompanyService)
        {
            return CompanyServiceRepository.UpdateService(CompanyService);
        }
        public bool DeleteService(int ServiceId)
        {
            return CompanyServiceRepository.DeleteService(ServiceId);
        }
    }
}
