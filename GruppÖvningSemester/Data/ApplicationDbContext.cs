using GruppÖvningSemester.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GruppÖvningSemester.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Allocation> Allocations { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<VacationType> VacationTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 1,
                FirstName = "Conny",
                LastName = "Svensson",
                Age = 12,
            });
        }
    }
}
