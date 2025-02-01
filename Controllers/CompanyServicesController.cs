using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TaskmanagementApi.DataLayer.Class;
using TaskmanagementApi.DataLayer.Class.GenericClass;
using TaskmanagementApi.DataLayer.DataBaseContexts;
using TaskmanagementApi.ServiceLayer.IServices;
using TaskmanagementApi.ServiceLayer.Services;

namespace TaskmanagementApi.Controllers
{
    [AllowAnonymous]
    [Route("api")]
    [ApiController]
    public class CompanyServicesController : Controller
    {
        public ICompanyService CompanyService { get; set; }

        public CompanyServicesController(ICompanyService companyService)
        {
            CompanyService = companyService;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("createservice")]
        public bool CreateServices(GenericCompanyServices companyService)
        {
            return CompanyService.CreateService(companyService);
        }

        [HttpGet]
        [Route("getallservices")]
        public IEnumerable<GenericCompanyServices> GetAllServices()
        {
            return CompanyService.GetAllServices();
        }

        [HttpGet]
        [Route("updateservice")]
        public bool UpdateService(GenericCompanyServices companyService)
        {
            return CompanyService.UpdateService(companyService);
        }

        [HttpGet]
        [Route("deleteservice")]
        public bool DeleteService(int ServiceId)
        {
            return CompanyService.DeleteService(ServiceId);
        }
    }
}
