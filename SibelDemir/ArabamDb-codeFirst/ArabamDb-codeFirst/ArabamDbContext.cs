using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabamDb_codeFirst
{
    public class ArabamDbContext : DbContext
    {
        public DbSet<Araba> Arabalar { get; set; }
        public DbSet<Muhendis> Muhendisler { get; set; }
        public DbSet<Plaka> Plakalar { get; set; }
        public DbSet<Sahip> Sahipler { get; set; }
        public DbSet<MuhendisAraba> MuhendisArabalar { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=192.168.1.34;database=ArabamDb;uid=sa; pwd=Password123;TrustServerCertificate=True");
        }
    }
}
