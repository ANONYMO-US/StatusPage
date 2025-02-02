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
        public bool CreateServices(CompanyServices companyService)
        {
            return CompanyService.CreateService(companyService);
        }

        [HttpGet]
        [Route("getallservices")]
        public IEnumerable<CompanyServices> GetAllServices()
        {
            return CompanyService.GetAllServices();
        }

        [HttpPut]
        [Route("updateservice")]
        public bool UpdateService(CompanyServices companyService)
        {
            return CompanyService.UpdateService(companyService);
        }

        [HttpDelete]
        [Route("deleteservice/{serviceId}")]
        public bool DeleteService(int serviceId)
        {
            return CompanyService.DeleteService(serviceId);
        }
    }
}
