using ANK15Okul.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK15Okul.Context
{
    public class Ank15OkulDbContext : DbContext
    {
        public DbSet<Diploma> Diplomalar { get; set; }
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Danisman> Danismanlar { get; set; }
        public DbSet<Ders> Dersler { get; set; }
        public DbSet<OgrenciDers> OgrenciDersler { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ANK2-YZLMORT-10;database=ANK15OkulDb;trusted_connection=true;trustservercertificate=true");
        }
    }
}
