using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kursovaya_work.Models;
using Isopoh.Cryptography.Argon2;

namespace Kursovaya_work.DB
{
    public class Context:DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Flight> Flight { get; set; }
        public DbSet<Route> Route { get; set; }
        public DbSet<Plane> Plane { get; set; }
        public DbSet<Airport> Airport { get; set; }

        public Context(DbContextOptions<Context> options)
            : base(options)
        {
            Database.EnsureCreated(); 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Person>().HasData(new Person() { Id = 1, Login = "admin", PasswordHash = Argon2.Hash("admin"), Role = UserRole.Admin });
        }
    }
}
