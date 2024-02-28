using EsyaMvc.Entitiys;
using Microsoft.EntityFrameworkCore;

namespace EsyaMvc.Context
{
    public class EsyaDbContext : DbContext
    {
        public DbSet<Esya> Esyalar { get; set; }
        public EsyaDbContext(DbContextOptions<EsyaDbContext> options) : base(options)
        {

        }
    }
}
