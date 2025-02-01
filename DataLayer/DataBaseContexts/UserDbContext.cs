using Microsoft.EntityFrameworkCore;
using TaskmanagementApi.DataLayer.Class;

namespace TaskmanagementApi.DataLayer.DataBaseContexts
{
    public class UserDbContext: DbContext
    {
        public DbSet<User> ListofUsers { get; set; }
        public string DbPath { get; }

        public UserDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "UserDatabase.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
