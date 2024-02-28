using Microsoft.EntityFrameworkCore;
using Odev_A_24.Entities;

namespace Odev_A_24.Context
{
    public class OyunDbContext : DbContext
    {
        public OyunDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Oyun> Oyun { get; set; }
    }
}
