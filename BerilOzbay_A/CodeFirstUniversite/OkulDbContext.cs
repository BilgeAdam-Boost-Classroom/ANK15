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
        public DbSet<Calisan> Calisanlar { get; set; }
        public DbSet <OgrenciDers>  OgrenciDers { get; set; }
        public DbSet <Sube>  Subeler { get; set; }
        public DbSet <Transkript>  Transkriptler { get; set; }
        public DbSet <Yazar>  Yazarlar { get; set; }
        public DbSet <Kitap>  Kitaplar { get; set; }
        public DbSet <YazarKitap>  YazarKitap { get; set; }
        public DbSet <Kütüphane>  Kütüphaneler { get; set; }
        public DbSet <KütüphaneKitap>  KütüphaneKitap { get; set; }
        public DbSet <Bandrol>  Bandroller { get; set; }
        public DbSet <YayınEvi>  YayinEvleri { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sube>()
                .HasKey(s => s.SubeBirincilAnahtar);

            modelBuilder.Entity<Sube>()
                .HasIndex(s => s.Ad)
                .IsUnique();

            modelBuilder.Entity<Sube>()
                .ToTable("Sections");

            modelBuilder.Entity<Laboratuvar>()
                .HasKey(l => l.L1);

            modelBuilder.Entity<Laboratuvar>()
                .Property(l => l.L1)
                .HasColumnName("L2");

            modelBuilder.Entity<Laboratuvar>()
                .Ignore(l => l.Tanım);

            modelBuilder.Entity<Sube>()
            .Property(o => o.Aciklama)
            .HasMaxLength(25) 
            .HasColumnType("nvarchar(25)");

            modelBuilder.Entity<Ogrenci>()
            .HasOne(o => o.Sube)
            .WithMany(s => s.Ogrenciler)
            .HasForeignKey(o => o.SubeYabanciAnahtar)
            .HasConstraintName("FK_Ogrenci_Sube");

            modelBuilder.Entity<Ogrenci>()
            .HasOne(o => o.Transkript)
            .WithOne(t => t.Ogrenci)
            .HasForeignKey<Ogrenci>(o => o.KarneId);

            modelBuilder.Entity<YazarKitap>()
            .HasOne(yk => yk.Kitap)
            .WithMany(k => k.YazarKitap)
            .HasForeignKey(ky => ky.Book);

            modelBuilder.Entity<YazarKitap>()
                .HasOne(ky => ky.Yazar)
                .WithMany(y => y.YazarKitap)
                .HasForeignKey(ky => ky.Author);

            modelBuilder.Entity<KütüphaneKitap>()
            .HasOne(yk => yk.Kitap)
            .WithMany(k => k.KütüphaneKitap)
            .HasForeignKey(ky => ky.KitapYabanciAnahtar);

            modelBuilder.Entity<KütüphaneKitap>()
                .HasOne(ky => ky.Kütüphane)
                .WithMany(y => y.KütüphaneKitap)
                .HasForeignKey(ky => ky.KütüphaneYabanciAnahtar);

            modelBuilder.Entity<Kitap>()
            .HasOne(k => k.Bandrol)
            .WithOne(b => b.Kitap)
            .HasForeignKey<Kitap>(k => k.BandrolYabancıAnahtar);

            modelBuilder.Entity<Kitap>()
            .HasOne(k => k.YayınEvi)
            .WithMany(y => y.Kitaplar)
            .HasForeignKey(k => k.YayinEviYabanciAnahtar);

        }

    }
}
