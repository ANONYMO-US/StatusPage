using TaskmanagementApi.BusinessLayer.IRepository;
using TaskmanagementApi.DataLayer.Class;
using TaskmanagementApi.DataLayer.Class.GenericClass;
using TaskmanagementApi.DataLayer.DataBaseContexts;
using TaskmanagementApi.ServiceLayer.Services;

namespace TaskmanagementApi.BusinessLayer.Repository
{
    public class CompanyServiceRepository : ICompanyServiceRepository
    {
        private readonly CompanyServicesDbContext _context = new CompanyServicesDbContext();
        public bool CreateService(CompanyServices CompanyService)
        {
            _context.ListofCompanyServices.Add(CompanyService);
            _context.SaveChanges();
            return true;
        }
        public IEnumerable<CompanyServices> GetAllServices()
        {
            var services = _context.ListofCompanyServices.OrderBy(b => b.ServiceId).ToList();   
            return services;
        }
        public bool UpdateService(CompanyServices CompanyService)
        {

            foreach (var services in _context.ListofCompanyServices)
            {
                if (services.ServiceId == CompanyService.ServiceId)
                {
                    services.ServiceName = CompanyService.ServiceName;
                    services.ServiceStatus = CompanyService.ServiceStatus;
                    services.TeamId = CompanyService.TeamId;
                    break;
                }
            }
            _context.SaveChanges();
            return true;
        }
        public bool DeleteService(int ServiceId)
        {
            foreach (var services in _context.ListofCompanyServices)
            {
                if (services.ServiceId == ServiceId)
                {
                    _context.ListofCompanyServices.Remove(services);
                    break;
                }
            }
            _context.SaveChanges();
            return true;
        }
    }
}
