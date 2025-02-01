using TaskmanagementApi.BusinessLayer.IRepository;
using TaskmanagementApi.DataLayer.Class.GenericClass;

namespace TaskmanagementApi.BusinessLayer.Repository
{
    public class IncidentsRepository : IIncidentsRepository
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
