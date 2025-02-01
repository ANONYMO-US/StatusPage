using Microsoft.EntityFrameworkCore;
using TaskmanagementApi.DataLayer.Class;

namespace TaskmanagementApi.DataLayer.DataBaseContexts
{
    public class IncidentsDbContext : DbContext
    {
        public DbSet<Incidents> ListofIncidents { get; set; }
        public string DbPath { get; }

        public IncidentsDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "IncidentDatabase.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
