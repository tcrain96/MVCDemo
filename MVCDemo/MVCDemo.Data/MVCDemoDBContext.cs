using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Linq;
using MVCDemo.Data.Models;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CDPOfficeSite.Data
{
    public partial class MVCDemoDBContext : DbContext
    {
        public MVCDemoDBContext()
        {
        }

        public MVCDemoDBContext(DbContextOptions<MVCDemoDBContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Department> Department { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("Data Source=.\\CARPEDIEMDB;Initial Catalog=cdp_office;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().Property(e => e.Email).IsRequired();
            modelBuilder.Entity<Employee>().Property(e => e.FirstName).IsRequired();
            modelBuilder.Entity<Employee>().Property(e => e.LastName).IsRequired();
            modelBuilder.Entity<Employee>().Property(e => e.PhoneNumber).IsRequired();
            modelBuilder.Entity<Employee>().Property(e => e.Department).IsRequired();

            modelBuilder.Entity<Department>().Property(d => d.DepartmentTitle).IsRequired();
            modelBuilder.Entity<Department>().Property(d => d.Employee).IsRequired();

        }

        public override int SaveChanges()
        {
            foreach (var entity in ChangeTracker.Entries().Where(e => e.State == EntityState.Added || e.State == EntityState.Modified))
            {
                var type = Type.GetType(entity.Metadata.ClrType.FullName);
                var properties = type.GetProperties().Where(t => t.PropertyType.Name == "String");

                foreach (var item in properties)
                {
                    if(item.CustomAttributes.Where(a => a.AttributeType.Name == "ConvertNullToEmptyAttribute").Count() > 0 
                       && item.GetValue(entity.Entity) == null)
                    {
                        item.SetValue(entity.Entity, string.Empty);    
                    }
                }
            }
            return base.SaveChanges();
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
