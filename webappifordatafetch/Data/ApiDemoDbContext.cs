using Microsoft.EntityFrameworkCore;
using webappifordatafetch.Model;

namespace webappifordatafetch.Data
{
    public class ApiDemoDbContext:DbContext
    {

        public DbSet<Employee> Employee { set; get; }

        public ApiDemoDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Employee>().HasIndex(Emp => Emp.Id).IsUnique();


        }
    }


}

