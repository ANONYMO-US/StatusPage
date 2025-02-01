using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TaskmanagementApi.DataLayer;
using TaskmanagementApi.DataLayer.Class;
using TaskmanagementApi.DataLayer.Class.GenericClass;
using TaskmanagementApi.DataLayer.DataBaseContexts;
using TaskmanagementApi.ServiceLayer.IServices;

namespace TaskmanagementApi.Controllers
{
    [AllowAnonymous]
    [Route("api")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public ILoginService LoginService { get; set; }

        public UsersController(ILoginService loginService)
        {
            LoginService = loginService;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("createuser")]
        public GenericUser CreateUser(GenericUser user)
        {
            return LoginService.CreateUser(user);
        }

        [HttpGet]
        [Route("isuser")]
        public bool IsUser(int ServiceId)
        {
            return LoginService.IsUserPresent(ServiceId);
        }
    }
}
