using Microsoft.EntityFrameworkCore;
using Ödev_A_13.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev_A_13.Cont
{
    internal class CarDbContext:DbContext

    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Engineer> Engineers { get; set; }
        public DbSet<LicencePlate> LicencePlates { get; set; }
        public DbSet<Person> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=TURKERSPC;Database=Odev13Car;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
