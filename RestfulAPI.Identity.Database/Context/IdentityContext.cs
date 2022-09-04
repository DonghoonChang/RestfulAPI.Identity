using Microsoft.EntityFrameworkCore;

namespace RestfulAPI.Identity.Database.Context;
public class IdentityContext : DbContext
{
    public IdentityContext(DbContextOptions<IdentityContext> options): base(options)
    {
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=localhost,11433;Database=RestfulAPI_Identity;Integrated Security=true;TrustServerCertificate=True");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
