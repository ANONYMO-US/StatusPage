using TaskmanagementApi.DataLayer.Class.GenericClass;

namespace TaskmanagementApi.BusinessLayer.IRepository
{
    public interface IIncidentsRepository
    {
        public GenericIncidents CreateIncident(GenericIncidents NewIncident);
        public bool UpdateIncident(GenericIncidents Incident);
        public bool ResolveIncident(int Incidentid);
        public bool AssociateIncidentWithService(int Incidentid, int ServiceId);
    }
}
