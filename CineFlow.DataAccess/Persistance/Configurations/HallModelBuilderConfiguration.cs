using CineFlow.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CineFlow.DataAccess.Persistance.Configurations;

public class HallModelBuilderConfiguration : BaseModelBuilderConfiguration<Hall>
{
    protected override void ApplyEntityConfiguration(EntityTypeBuilder<Hall> builder)
    {
        builder.HasMany(x => x.ShowTimes)
            .WithOne(x => x.Hall)
            .HasForeignKey(x => x.HallId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(x => x.Seats)
            .WithOne(x => x.Hall)
            .HasForeignKey(x => x.HallId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(x => x.Name).IsRequired()
            .HasMaxLength(100);

        builder.Property(x => x.Capacity).IsRequired();

    }
}
