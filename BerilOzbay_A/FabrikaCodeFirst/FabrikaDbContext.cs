using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabrikaCodeFirst
{
    public class FabrikaDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-LAQPBG1\\MSSQLSERVER02;Database=FabrikaDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<Araba> Arabalar { get; set; }
        public DbSet<Kisi> Kisiler { get; set; }
        public DbSet<Muhendis> Muhendisler { get; set; }
        public DbSet<Plaka> Plakalar { get; set; }
        public DbSet<MuhendisAraba> MuhendisAraba { get; set; }

    }
}
