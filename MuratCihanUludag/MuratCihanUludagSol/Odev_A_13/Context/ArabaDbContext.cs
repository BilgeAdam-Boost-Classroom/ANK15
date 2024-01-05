using Microsoft.EntityFrameworkCore;
using Odev_A_13.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_A_13.Context
{
    public class ArabaDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=P96ANV;Database=ArabaDb;Trusted_Connection=True;TrustServerCertificate=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Araba>().HasOne(a => a.Plaka)
                                        .WithOne(p => p.Araba)
                                        .HasForeignKey<Araba>(a => a.PlakaId);
        }
        public DbSet<Araba> Arabalar { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Engineer> Engineers { get; set; }
        public DbSet<Plaka> Plakalar { get; set; }

    }
}
