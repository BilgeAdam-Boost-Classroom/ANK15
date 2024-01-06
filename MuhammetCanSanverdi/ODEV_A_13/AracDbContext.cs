using Microsoft.EntityFrameworkCore;

namespace ODEV_A_13
{
    public class AracDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-VUKATPV;Database=AracDb;Trusted_connection=true;");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Araba> Araba { get; set; }
        public DbSet<Muhendis> Muhendis { get; set; }
        public DbSet<Plaka> Plaka { get; set; }
        public DbSet<Kisi> Kisi { get; set; }
    }
}
