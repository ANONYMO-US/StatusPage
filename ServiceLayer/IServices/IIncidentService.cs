using TaskmanagementApi.DataLayer.Class.GenericClass;

namespace TaskmanagementApi.ServiceLayer.IServices
{
    public interface IIncidentService
    {
        public GenericIncidents CreateIncident(GenericIncidents NewIncident);
        public bool UpdateIncident(GenericIncidents Incident);
        public bool ResolveIncident(int Incidentid);
        public bool AssociateIncidentWithService(int Incidentid, int ServiceId);
    }
}
