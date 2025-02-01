using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using TaskmanagementApi.DataLayer;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TaskmanagementApi.Controllers
{
    [AllowAnonymous]
    [Route("api")]
    [ApiController]
    
    public class TaskController : ControllerBase
    {
        private readonly DataLayer.Task task = new DataLayer.Task();
        // GET: api/<TaskController>
        [AllowAnonymous]
        [HttpGet]
        [Route("getTask")]
        public IEnumerable<DataLayer.Task> Get()
        {
            return task.fetchalltasks();
        }

        // GET api/<TaskController>/5
        [HttpGet]
        [Route("getTaskbyId/{id}")]
        public IEnumerable<DataLayer.Task> Get(int id)
        {
            return task.getTaskbyId(id);

        }

        // POST api/<TaskController>
        [HttpPost]
        [Route("postTask")]
        public void Post([FromBody] string value)   
        {
            task.postNewTask(value);
            return;
        }

        // PUT api/<TaskController>/5
        [HttpPut("UpdateTask/{id}")]
        public void Put(int id, [FromBody] string value)  
        {         
            task.updateTask(id, value);
            return;
        }

        // DELETE api/<TaskController>/5
        [HttpDelete("deleteTask/{id}")]
        public void Delete(int id) 
        {
            task.deleteTask(id);
            return;
        }
    }
}
