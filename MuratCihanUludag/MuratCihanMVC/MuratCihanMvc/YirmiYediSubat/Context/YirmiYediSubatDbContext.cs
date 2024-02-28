using Microsoft.EntityFrameworkCore;
using YirmiYediSubat.Entities;

namespace YirmiYediSubat.Context
{
    public class YirmiYediSubatDbContext : DbContext
    {
        public DbSet<Malzeme> Malzemeler { get; set; }
        public YirmiYediSubatDbContext(DbContextOptions<YirmiYediSubatDbContext> options) : base(options)
        {

        }
    }
}
