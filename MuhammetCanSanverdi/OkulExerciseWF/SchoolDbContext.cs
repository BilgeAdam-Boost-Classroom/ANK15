using Microsoft.EntityFrameworkCore;
using OkulExerciseWF.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolExercise
{
    public class SchoolDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-VUKATPV;Database=SchoolWFDb;Trusted_connection=true;");
            base.OnConfiguring(optionsBuilder);

        }
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Diploma> Diplomalar { get; set; }
        public DbSet<Danisman> Danismanlar { get; set; }
        public DbSet<Ders> Dersler { get; set; }
        public DbSet<OgrenciDers> OgrenciDersler { get; set; }
    }
}

