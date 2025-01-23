using DAL.Configurations;
using DAL.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DAL.Contexts;

public class AppDbContext : IdentityDbContext<IdentityUser  , IdentityRole, string>
{
    public DbSet<Worker> Workers { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<AppUser> AppUsers { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(WorkerConfiguration).Assembly);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ServiceConfiguration).Assembly);

        base.OnModelCreating(modelBuilder);
    }

}
