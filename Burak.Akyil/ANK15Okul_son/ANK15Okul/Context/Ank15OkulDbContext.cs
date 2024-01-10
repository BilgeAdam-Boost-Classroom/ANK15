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
        public DbSet<Transcript> Transcriptler { get; set; }
        public DbSet<Yazar> Yazarlar { get; set; }
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<YazarKitap> YazarKitaplar { get; set; }
        public DbSet<Kutuphane> Kutuphaneler { get; set; }
        public DbSet<KutuphaneKitap> KutuphaneKitaplar { get; set; }
        public DbSet<Bandrol> Bandroller { get; set; }
        public DbSet<YayinEvi> YayinEvleri { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-O718654;databasE=ANK15OkulDb;trusted_connection=true;trustservercertificate=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sube>()
                .HasIndex(s => s.Ad).IsUnique();

            modelBuilder.Entity<Sube>()
                .ToTable("Sections");

            modelBuilder.Entity<Sube>()
                .HasKey(s => s.SubeBirincilAnahtar);

            modelBuilder.Entity<Laboratuvar>()
                .HasKey(l => l.L1);

            modelBuilder.Entity<Laboratuvar>()
                .Property(l => l.L1)
                .HasColumnName("L2");

            modelBuilder.Entity<Laboratuvar>()
                .Ignore(l => l.Tanim);

            modelBuilder.Entity<Sube>()
                .Property(s => s.Aciklama)
                .HasColumnType("nvarchar(250)");

            modelBuilder.Entity<Ogrenci>()
                .HasOne(o => o.Sube)
                .WithMany(d => d.Ogrenciler)
                .HasForeignKey(p => p.SubeYabancıAnahtar);

            modelBuilder.Entity<Ogrenci>()
                .HasOne(o => o.Transcript)
                .WithOne(t => t.Ogrenci)
                .HasForeignKey<Ogrenci>(o => o.KarneId);

            modelBuilder.Entity<YazarKitap>()
                .HasOne(y => y.Yazar)
                .WithMany(y => y.YazarKitaplar)
                .HasForeignKey(y => y.Author);

            modelBuilder.Entity<YazarKitap>()
                .HasOne(y => y.Kitap)
                .WithMany(y => y.KitapYazarlar)
                .HasForeignKey(y => y.Book);

            modelBuilder.Entity<KutuphaneKitap>()
                .HasOne(k => k.Kitap)
                .WithMany(k => k.kutuphaneKitaplar)
                .HasForeignKey(k => k.KitapNo);

            modelBuilder.Entity<KutuphaneKitap>()
                .HasOne(k => k.Kutuphane)
                .WithMany(k => k.kutuphaneKitaplar)
                .HasForeignKey(k => k.KutuphaneNo);

            modelBuilder.Entity<Kitap>()
                .HasOne(k => k.Bandrol)
                .WithOne(b => b.Kitap)
                .HasForeignKey<Kitap>(k => k.BandrolNo);

            modelBuilder.Entity<Kitap>()
                .HasOne(k => k.YayinEvi)
                .WithMany(y => y.Kitaplar)
                .HasForeignKey(k => k.YayinEviNo);

        }
    }
}
