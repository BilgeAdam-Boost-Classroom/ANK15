using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeFirstokul
{
    public class OkulDbContext:DbContext
    {
        public DbSet<Diploma> Diplomalars {  get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        optionsBuilder.UseSqlServer("server=DESKTOP-                             A7N4232;database=ANK15OkulDb;trusted_connection=true;trustservercertificate=true;");



        }

    }
}
