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
            optionsBuilder.UseSqlServer("Server=P96ANV;Database=OkulDb;Trusted_Connection=True;TrustServerCertificate=true;");
        }

        public DbSet<Diploma> Diplomas { get; set; }
    }
}
