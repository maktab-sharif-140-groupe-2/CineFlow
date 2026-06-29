using CineFlow.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CineFlow.DataAccess.Persistance.Configurations;

public class CinemaModelBuilderConfiguration : BaseModelBuilderConfiguration<Cinema>
{
    protected override void ApplyEntityConfiguration(EntityTypeBuilder<Cinema> builder)
    {
        builder.Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(25);

        builder.Property(c => c.Address)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(c => c.City)
            .IsRequired()
            .HasMaxLength(30);

        builder.HasMany(c => c.Halls)
            .WithOne(h => h.Cinema)
            .HasForeignKey(h => h.CinemaId)
            .OnDelete(DeleteBehavior.Restrict)
            .IsRequired();
    }
}
