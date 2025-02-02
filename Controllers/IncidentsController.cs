using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
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
    public class IncidentsController : Controller
    {
        public IIncidentService IncidentService { get; set; }

        public IncidentsController(IIncidentService incidentService)
        {
            IncidentService = incidentService;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("createincident")]
        public GenericIncidents CreateIncident([FromBody] Incidents NewIncident)
        {
            return IncidentService.CreateIncident(NewIncident);
        }

        [HttpGet]
        [Route("updateincident")]
        public bool UpdateIncident(GenericIncidents Incident)
        {
            return IncidentService.UpdateIncident(Incident);
        }

        [HttpGet]
        [Route("resolveincident")]
        public bool ResolveIncident(int Incidentid)
        {
            return IncidentService.ResolveIncident(Incidentid);
        }

        [HttpGet]
        [Route("associateincidentwithservice")]
        public bool AssociateIncidentWithService(int Incidentid, int ServiceId)
        {
            return IncidentService.AssociateIncidentWithService(Incidentid,ServiceId);
        }
    }
}
