using CineFlow.Core.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CineFlow.DataAccess.Persistance.Configurations;

public abstract class BaseModelBuilderConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseEntity
{

    public void Configure(EntityTypeBuilder<T> builder)
    {
        builder.HasKey(b => b.Id);

        builder.HasIndex(b => b.CreatedAt);

        builder.Property(b => b.CreatedAt)
        .HasDefaultValueSql("GETUTCDATE()");

        builder.Property(b => b.IsDelete)
        .HasDefaultValue(false);

        builder.HasQueryFilter(b => !b.IsDelete && b.DeleteAt == null);

        ApplyEntityConfiguration(builder);

    }


    protected abstract void ApplyEntityConfiguration(EntityTypeBuilder<T> builder);

}
