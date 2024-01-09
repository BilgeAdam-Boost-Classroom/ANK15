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
        public DbSet<Ders> Dersler { get; set; }

        public DbSet<Ogrenci> Ogrenciler { get; set; }

        public DbSet<Danisman> Danismanlar { get; set; }

        public DbSet<OgrenciDers> OgrenciDersler { get; set; }
        public DbSet<Calisan> Calisanlar { get; set; }
        public DbSet<Sube> Subeler { get; set; }
        public DbSet<Laboratuvar> Laboratuvarlar { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ANK2-YZLMORT-10;databasE=ANK15OkulDb;trusted_connection=true;trustservercertificate=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sube>()
                .HasIndex(s => s.Ad).IsUnique();
            modelBuilder.Entity<Sube>().ToTable("Sections");
            modelBuilder.Entity<Sube>().HasKey(s => s.SubeBirincilAnahtar);
            modelBuilder.Entity<Laboratuvar>().HasKey(l => l.L1);
            modelBuilder.Entity<Laboratuvar>().Property(l => l.L1).HasColumnName("L2");
            modelBuilder.Entity<Laboratuvar>().Ignore(l => l.Tanim);
            modelBuilder.Entity<Sube>().Property(s => s.Aciklama).HasColumnType("nvarchar(250)");
            modelBuilder.Entity<Ogrenci>().HasOne(o => o.Sube).WithMany(d => d.Ogrenciler).HasForeignKey(p => p.SubeYabancıAnahtar);
        }
    }
}
