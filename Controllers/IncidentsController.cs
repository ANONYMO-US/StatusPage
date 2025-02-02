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

        [HttpPut]
        [Route("updateincident")]
        public bool UpdateIncident(Incidents Incident)
        {
            return IncidentService.UpdateIncident(Incident);
        }

        [HttpPost]
        [Route("resolveincident")]
        public bool ResolveIncident([FromBody]int Incidentid)
        {
            return IncidentService.ResolveIncident(Incidentid);
        }

        [HttpPut]
        [Route("associateincidentwithservice/{Incidentid}")]
        public bool AssociateIncidentWithService(int Incidentid, [FromBody] int ServiceId)
        {
            return IncidentService.AssociateIncidentWithService(Incidentid,ServiceId);
        }

        [HttpGet]
        [Route("getallincidents")]
        public IEnumerable<Incidents> GetAllIncidents()
        {
            return IncidentService.GetAllIncidents();
        }
    }
}
