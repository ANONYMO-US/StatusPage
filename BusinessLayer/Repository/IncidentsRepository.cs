using TaskmanagementApi.BusinessLayer.IRepository;
using TaskmanagementApi.DataLayer;
using TaskmanagementApi.DataLayer.Class;
using TaskmanagementApi.DataLayer.Class.GenericClass;
using TaskmanagementApi.DataLayer.DataBaseContexts;

namespace TaskmanagementApi.BusinessLayer.Repository
{
    public class IncidentsRepository : IIncidentsRepository
    {
        private readonly IncidentsDbContext _context = new IncidentsDbContext();
        public Incidents CreateIncident(Incidents NewIncident)
        {
            _context.ListofIncidents.Add(NewIncident);
            _context.SaveChanges();
            return NewIncident;
        }
        public bool UpdateIncident(Incidents Incident)
        {
            foreach (var incident in _context.ListofIncidents)
            {
                if (incident.IncidentId == Incident.IncidentId)
                {
                    incident.ServiceId = Incident.ServiceId;
                    incident.IncidentStatus = Incident.IncidentStatus;
                    break;
                }
            }
            _context.SaveChanges();

            return true;
        }
        public bool ResolveIncident(int Incidentid)
        {
            foreach (var incident in _context.ListofIncidents)
            {
                if (incident.IncidentId == Incidentid)
                {
                    incident.IncidentStatus = "Resolved";
                    break;
                }
            }
            _context.SaveChanges();
            return true;
        }
        public bool AssociateIncidentWithService(int Incidentid, int ServiceId)
        {
            foreach (var incident in _context.ListofIncidents)
            {
                if (incident.IncidentId == Incidentid)
                {
                    incident.ServiceId = ServiceId;
                    break;
                }
            }
            _context.SaveChanges();
            return true;
        }
    }
}
