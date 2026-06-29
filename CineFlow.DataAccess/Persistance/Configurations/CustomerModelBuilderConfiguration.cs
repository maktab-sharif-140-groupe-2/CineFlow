using CineFlow.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CineFlow.DataAccess.Persistance.Configurations;

public class CustomerModelBuilderConfiguration : BaseModelBuilderConfiguration<Customer>
{
    protected override void ApplyEntityConfiguration(EntityTypeBuilder<Customer> builder)
    {
        builder.Property(x => x.FirstName).HasMaxLength(50).IsRequired();
        builder.Property(x => x.FirstName).HasMaxLength(50).IsRequired();
        builder.Property(x => x.PhoneNumber).HasMaxLength(50).IsRequired();
        builder.Property(x => x.FirstName).HasMaxLength(50).IsRequired();


    }
}
