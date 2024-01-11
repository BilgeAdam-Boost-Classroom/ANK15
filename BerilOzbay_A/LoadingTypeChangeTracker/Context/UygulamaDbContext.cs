using LoadingTypeChangeTracker.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadingTypeChangeTracker.Context
{
    public class UygulamaDbContext : DbContext
    {
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Lisans> Lisanslar { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-LAQPBG1\\MSSQLSERVER02;Database=LoadingChangeTrackerDb;Trusted_Connection=True;TrustServerCertificate=True;");
            optionsBuilder.UseLazyLoadingProxies(false);
        }
    }
}
