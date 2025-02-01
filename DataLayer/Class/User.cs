using System.ComponentModel.DataAnnotations;
using TaskmanagementApi.DataLayer.Class.GenericClass;

namespace TaskmanagementApi.DataLayer.Class
{
    //Inheriting Generic Class to promote scalability 
    public class User : GenericUser
    {
        [Key]
        public int UserId { get; set; }
        public string EmailId {  get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int TeamId { get; set; }
        public int OrgId { get; set; }


    }
}
