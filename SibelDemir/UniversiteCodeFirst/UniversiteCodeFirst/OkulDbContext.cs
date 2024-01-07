using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversiteCodeFirst
{
    public class OkulDbContext:DbContext
    {
        public DbSet<Diploma> Diplomalar { get; set;}
        public DbSet<Ogrenci> Ogrenciler { get; set;}
        public DbSet<Danisman> Danisman { get; set;}
        public DbSet<Ders> Dersler { get; set; }
        public DbSet<OgrenciDers> OgrenciDersler {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=192.168.1.34;database=ANK15OkulDb;uid=sa; pwd=Password123;TrustServerCertificate=True");
        }
    }

}

