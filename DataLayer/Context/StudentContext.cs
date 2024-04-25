using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;
using Microsoft.EntityFrameworkCore;
using DTO.Enum;

namespace DataLayer.Context
{
    internal class StudentContext : DbContext
    {
        public StudentContext() 
        {
            bool created = Database.EnsureCreated();
            if (created)
            {
                Debug.WriteLine("Database created");
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-MNTPTOQP\\SQLEXPRESS;Initial Catalog=L16Csharp-Students;Integrated Security=SSPI; TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(new Student[]
            {
                new Student{StudentID = -1, Name = "Test", StartDate = DateTime.Now, StudentType = StudentTypes.Undergraduate }
            });
        }

        public DbSet<Student> Students { get; set; }
    }
}
