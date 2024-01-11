using Ank15LoadingChangeTracker.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ank15LoadingChangeTracker.Context
{
    internal class UygulamaDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=P96ANV;Database=ChanceTracker;Trusted_Connection=True;TrustServerCertificate=true;");

            optionsBuilder.UseLazyLoadingProxies(false);
        }
        public DbSet<Lisans> Lisanslar { get; set; }
        public DbSet<Urun> Urunler { get; set; }
    }
}
