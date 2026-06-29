using CineFlow.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CineFlow.DataAccess.Persistance.Configurations;

public class CustomerModelBuilderConfiguration : BaseModelBuilderConfiguration<Customer>
{
    protected override void ApplyEntityConfiguration(EntityTypeBuilder<Customer> builder)
    {
        builder.Property(x => x.FirstName).HasMaxLength(50).IsRequired();

        builder.Property(x => x.PasswordHash).HasColumnType("NVARCHAR(80)").IsRequired();

        builder.Property(x => x.FirstName).HasMaxLength(50).IsRequired();

        builder.Property(x => x.PhoneNumber).HasMaxLength(15).IsRequired();

        builder.Property(x => x.Email).HasMaxLength(50).IsRequired();

        builder.HasIndex(x => x.PhoneNumber).IsUnique();

        builder.HasIndex(x => x.Email).IsUnique();

        builder.HasMany(x => x.Tickets)
            .WithOne(x => x.Customer)
            .HasForeignKey(x => x.CustomerId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(m => m.Role)
        .IsRequired()
        .HasConversion<string>()
        .HasMaxLength(25);

    }
}
