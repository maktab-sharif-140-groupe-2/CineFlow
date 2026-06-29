using CineFlow.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CineFlow.DataAccess.Persistance.Configurations;

public class SeatModelBuilderConfiguration : BaseModelBuilderConfiguration<Seat>
{
    protected override void ApplyEntityConfiguration(EntityTypeBuilder<Seat> builder)
    {
        builder.Property(s => s.Row)
            .IsRequired()
            .HasDefaultValue(0);

        builder.Property(s => s.Number)
            .IsRequired()
            .HasDefaultValue(0);

        builder.Property(m => m.Type)
           .IsRequired()
           .HasConversion<string>()
           .HasMaxLength(10);
    }
}
