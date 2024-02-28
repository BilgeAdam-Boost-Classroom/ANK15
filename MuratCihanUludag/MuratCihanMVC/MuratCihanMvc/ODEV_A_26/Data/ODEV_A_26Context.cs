using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ODEV_A_26.Entities;

namespace ODEV_A_26.Data
{
    public class ODEV_A_26Context : DbContext
    {
        public ODEV_A_26Context (DbContextOptions<ODEV_A_26Context> options)
            : base(options)
        {
        }

        public DbSet<ODEV_A_26.Entities.Cihaz> Cihaz { get; set; } = default!;
    }
}
