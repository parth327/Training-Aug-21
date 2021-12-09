using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAPI.Models
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext(DbContextOptions options)
           : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Employee_Assigment> Employee_Assignments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server =.\\SQLEXPRESS; Database = EmployeeDB; Trusted_Connection = True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //assignment
            modelBuilder.Entity<Assignment>()
                 .Property(p => p.AssignmentId)
                 .UseIdentityColumn()
                 .IsRequired();

            //employee
            modelBuilder.Entity<Employee>()
                 .Property(p => p.Id)
                 .UseIdentityColumn()
                 .IsRequired();

            //employee-assignment
            modelBuilder.Entity<Employee_Assigment>()
                 .Property(p => p.Id)
                 .UseIdentityColumn()
                 .IsRequired();

            modelBuilder.Entity<Employee_Assigment>()
                .HasOne<Employee>(e => e.Employee)
                .WithMany(a => a.Employee_Assignments)
                .HasForeignKey(b => b.EmployeeId);

            modelBuilder.Entity<Employee_Assigment>()
                .HasOne<Assignment>(e => e.Assignment)
                .WithMany(a => a.Employee_Assignments)
                .HasForeignKey(b => b.AssignmentId);
        }
    }
}

