using Ex03_01_2024.Models;
using Microsoft.EntityFrameworkCore;


namespace Ex03_01_2024.Context
{
    public class OkulDbContext : DbContext
    {
        public OkulDbContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=P96ANV;Database=Okul2Db;Trusted_Connection=True;TrustServerCertificate=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ogrenci>().HasOne(o => o.Diploma)
                                          .WithOne(d => d.Ogrenci)
                                          .HasForeignKey<Ogrenci>(d => d.DiplomaId)
                                          .OnDelete(DeleteBehavior.NoAction);

        }

        public DbSet<Diploma> Diplomas { get; set; }
        public DbSet<Ogrenci> Orenciler { get; set; }
        public DbSet<Danisman> Danismanlar { get; set; }
        public DbSet<Ders> Dersler { get; set; }
        public DbSet<OgrenciDers> OgrenciDerses { get; set; }
    }
}
