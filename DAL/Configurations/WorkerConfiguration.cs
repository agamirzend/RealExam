using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configurations;

public class WorkerConfiguration : IEntityTypeConfiguration<Worker>
{
    public void Configure(EntityTypeBuilder<Worker> builder)
    {
        builder.HasOne(w=>w.Service).WithMany(s=>s.Workers).HasForeignKey(w=>w.ServiceId).OnDelete(DeleteBehavior.NoAction);
        builder.Property(w=>w.Name).IsRequired().HasMaxLength(15);
        builder.Property(w => w.ImgPath).IsRequired();
    }
}
