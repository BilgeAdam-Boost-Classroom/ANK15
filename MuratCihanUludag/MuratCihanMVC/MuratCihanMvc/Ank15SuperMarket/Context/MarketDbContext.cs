using Ank15SuperMarket.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ank15SuperMarket.Context
{
    public class MarketDbContext : DbContext
    {
        public DbSet<Urun> Urunler { get; set; }
        public MarketDbContext(DbContextOptions<MarketDbContext> options) : base(options)
        {

        }

    }
}
