using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolWindowsForm
{
    public class ANK15OkulDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
                
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-VUKATPV;Database=ANK15OkulDb;Trusted_connection=true;");
            
        }

        public DbSet<Diploma> Diplomalar { get; set; }
    }

    public class Diploma
    {
        public int Id { get; set; }
        public string No { get; set; }
        public DateTime Tarih { get; set; }
    }

     
}
