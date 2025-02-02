using TaskmanagementApi.BusinessLayer.IRepository;
using TaskmanagementApi.DataLayer.Class;
using TaskmanagementApi.DataLayer.Class.GenericClass;
using TaskmanagementApi.ServiceLayer.IServices;

namespace TaskmanagementApi.ServiceLayer.Services
{
    public class IncidentService : IIncidentService
    {
        public IIncidentsRepository IIncidentsRepository { get; set; }
        public IncidentService(IIncidentsRepository incidentsRepository)
        {
            IIncidentsRepository = incidentsRepository;
        }
        public GenericIncidents CreateIncident(GenericIncidents NewIncident)
        {
            return IIncidentsRepository.CreateIncident((Incidents)NewIncident);
        }
        public bool UpdateIncident(Incidents Incident)
        {
            return IIncidentsRepository.UpdateIncident(Incident);
        }
        public bool ResolveIncident(int Incidentid)
        {
            return IIncidentsRepository.ResolveIncident(Incidentid);
        }
        public bool AssociateIncidentWithService(int Incidentid, int ServiceId)
        {
            return IIncidentsRepository.AssociateIncidentWithService(Incidentid, ServiceId);
        }

        public IEnumerable<Incidents> GetAllIncidents()
        {
            return IIncidentsRepository.GetAllIncidents();
        }
    }
}
