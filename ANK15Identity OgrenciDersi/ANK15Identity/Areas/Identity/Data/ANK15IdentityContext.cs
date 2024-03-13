using ANK15Identity.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ANK15Identity;

namespace ANK15Identity.Areas.Identity.Data;

public class ANK15IdentityContext : IdentityDbContext<ANK15IdentityUser>
{
    public ANK15IdentityContext(DbContextOptions<ANK15IdentityContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

    public DbSet<ANK15Identity.Rol>? Rol { get; set; }

    public DbSet<Lesson>? Lessons { get; set; }
}
