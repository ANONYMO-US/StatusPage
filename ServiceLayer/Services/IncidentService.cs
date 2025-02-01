using TaskmanagementApi.DataLayer.Class.GenericClass;
using TaskmanagementApi.ServiceLayer.IServices;

namespace TaskmanagementApi.ServiceLayer.Services
{
    public class IncidentService : IIncidentService
    {
        public GenericIncidents CreateIncident(GenericIncidents NewIncident)
        {
            return NewIncident;
        }
        public bool UpdateIncident(GenericIncidents Incident)
        {
            return true;
        }
        public bool ResolveIncident(int Incidentid)
        {
            return true;
        }
        public bool AssociateIncidentWithService(int Incidentid, int ServiceId)
        {
            return true;
        }
    }
}
