using System.ComponentModel.DataAnnotations;
using TaskmanagementApi.DataLayer.Class.GenericClass;

namespace TaskmanagementApi.DataLayer.Class
{
    //Inheriting Generic Class to promote scalability 
    public class CompanyServices : GenericCompanyServices
    {
        [Key]
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public string ServiceStatus { get; set;}
        public int TeamId { get; set;}    

    }
}
