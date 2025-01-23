using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configurations;

public class ServiceConfiguration : IEntityTypeConfiguration<Service>
{
    public void Configure(EntityTypeBuilder<Service> builder)
    {
        builder.HasMany(s=>s.Workers).WithOne(w=>w.Service).HasForeignKey(w=>w.ServiceId).OnDelete(DeleteBehavior.NoAction);
        builder.Property(s=>s.Name).IsRequired().HasMaxLength(15);
        builder.Property(s=>s.Description).IsRequired().HasMaxLength(200);
    }
}
