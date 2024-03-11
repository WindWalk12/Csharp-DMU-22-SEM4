using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8exercises
{
    internal class CarContext : DbContext
    {
        public CarContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-MNTPTOQP\\SQLEXPRESS;Initial Catalog=Csharp-Cars;Integrated Security=SSPI; TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(new Car[]
            {
                new Car{CarId = -1, Model="Mercedes", HorsePower=300, Age=10, OwnerId=-1 }
            });

            modelBuilder.Entity<Owner>().HasData(new Owner[]
            {
                new Owner{OwnerId=-1, Name="John"}
            });
        }

        public DbSet<Car> Cars { get; set;}
        public DbSet<Owner> Owners { get; set;}
    }
}
