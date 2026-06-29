using CineFlow.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CineFlow.DataAccess.Persistance.Configurations;

public class ShowTimeModelBuilderConfiguration : BaseModelBuilderConfiguration<ShowTime>
{
    protected override void ApplyEntityConfiguration(EntityTypeBuilder<ShowTime> builder)
    {

        builder.Property(x => x.BasePrice).HasColumnType("decimal(0,12)").IsRequired();

        builder.HasMany(x=> x.Tickets)
            .WithOne(x=> x.ShowTime)
            .HasForeignKey(x=> x.ShowTimeId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Restrict);


        builder.Property(m => m.Status)
        .IsRequired()
        .HasConversion<string>()
        .HasMaxLength(25);



    }
}
