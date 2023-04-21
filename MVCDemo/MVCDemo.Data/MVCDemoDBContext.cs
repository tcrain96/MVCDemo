using Microsoft.EntityFrameworkCore;
using MVCDemo.Data.Models;


namespace MVCDemo.Data
{
    public class MVCDemoDBContext : DbContext
    {
        public MVCDemoDBContext(DbContextOptions<MVCDemoDBContext> options)
            : base(options)
        {
        }

        //entities
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Departments> Departments { get; set; }
 
    }
}
