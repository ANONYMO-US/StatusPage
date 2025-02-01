using System.ComponentModel.DataAnnotations;
using TaskmanagementApi.DataLayer.Class.GenericClass;

namespace TaskmanagementApi.DataLayer.Class
{
    //Inheriting Generic Class to promote scalability 
    public class Incidents : GenericIncidents
    {
        [Key]
        public int IncidentId { get; set; }
        public int ServiceId { get; set; }
        public string IncidentStatus { get; set; }

    }
}
