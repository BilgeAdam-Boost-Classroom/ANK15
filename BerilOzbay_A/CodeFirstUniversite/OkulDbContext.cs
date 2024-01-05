using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstUniversite
{
    public class OkulDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             optionsBuilder.UseSqlServer("Server=DESKTOP-LAQPBG1\\MSSQLSERVER02;Database=ANK15OkulDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        public DbSet<Diploma> Diplomas { get; set; }
        public DbSet<Ogrenci> Ogrencis { get; set; }
        public DbSet<Danisman> Danismans { get; set;}
        public DbSet<Ders> Dersler { get; set; }
        public DbSet <OgrenciDers>  OgrenciDers { get; set; }

    }
}
