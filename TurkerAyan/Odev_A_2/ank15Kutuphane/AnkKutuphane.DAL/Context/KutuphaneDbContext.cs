using AnkKutuphane.DAL.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnkKutuphane.DAL.Context
{
    public class KutuphaneDbContext:DbContext
    {

        public DbSet<kitap> Kitaps { get; set; }
        public DbSet<YayinEvi> YayinEvis { get; set; }
        public DbSet<Bandrol> Bandrols { get; set; }
        public DbSet<Kutuphane> Kutuphanes { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=TURKERSPC;Database=AnkKutuphane12012024;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //1-1
            modelBuilder.Entity<kitap>()
                        .HasOne(k => k.Bandrol)
                        .WithOne(b => b.kitap)
                        .HasForeignKey<kitap>(k => k.Etiket);
            //1-m
            modelBuilder.Entity<kitap>()
                        .HasOne(k => k.YayinEvi)
                        .WithMany(ye => ye.kitaps)
                        .HasForeignKey(k => k.BasimYeri);
            //m-m
            modelBuilder.Entity<kitap>()
                .HasMany(k => k.Kutuphanes)
                .WithMany(kh => kh.kitaps);





        }
    }
}
