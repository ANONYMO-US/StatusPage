using TaskmanagementApi.DataLayer.Class;
using TaskmanagementApi.DataLayer.Class.GenericClass;

namespace TaskmanagementApi.BusinessLayer.IRepository
{
    public interface IIncidentsRepository
    {
        public Incidents CreateIncident(Incidents NewIncident);
        public bool UpdateIncident(Incidents Incident);
        public bool ResolveIncident(int Incidentid);
        public bool AssociateIncidentWithService(int Incidentid, int ServiceId);
        public IEnumerable<Incidents> GetAllIncidents();
    }
}
