using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LodingChangeTracker.Concrete;
using Microsoft.EntityFrameworkCore;

namespace LodingChangeTracker.Context
{
    public class UygulamaDbContext:DbContext
    {
        public DbSet<Urun> Uruns { get; set; }
        public DbSet<Lisans> Lisans { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=TURKERSPC;Database=EsyaDb;Trusted_Connection=True;TrustServerCertificate=True;");
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
