using System.ComponentModel.DataAnnotations;

namespace TaskmanagementApi.DataLayer
{
    public class Task
    {
        [Key] 
        public int Id { get; set; }
        public string? Description { get; set; }

        private readonly TaskDbContext _context = new TaskDbContext();

        public IEnumerable<DataLayer.Task> fetchalltasks()
        {
            var tasks = _context.ListofTasks.OrderBy(b => b.Id);
            return tasks;
        }

        public IEnumerable<DataLayer.Task> getTaskbyId(int id)
        {
            var tasks = _context.ListofTasks.Where(b => b.Id == id);
            return tasks;
        }

        public void postNewTask(string value)
        {
            DataLayer.Task newtask = new DataLayer.Task();
            newtask.Description = value;
            _context.ListofTasks.Add(newtask);
            _context.SaveChanges();
            return;
        }

        public void updateTask(int id, string value) 
        {
            foreach (var task in _context.ListofTasks)
            {
                if (task.Id == id)
                {
                    task.Description = value;
                    break;
                }
            }
            _context.SaveChanges();
            return;
        }

        public void deleteTask(int id) 
        {
            foreach (var task in _context.ListofTasks)
            {
                if (task.Id == id)
                {
                    _context.ListofTasks.Remove(task);
                    break;
                }
            }
            _context.SaveChanges();
            return;
        }
    }
}
