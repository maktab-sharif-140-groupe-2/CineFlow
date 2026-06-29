using CineFlow.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CineFlow.DataAccess.Persistance.Configurations;

public class TicketModelBuilderConfiguration : BaseModelBuilderConfiguration<Ticket>
{
    protected override void ApplyEntityConfiguration(EntityTypeBuilder<Ticket> builder)
    {
        builder.Property(x => x.Price).HasColumnType("decimal(0,12)").IsRequired();

        builder.HasOne(x => x.Seat)
            .WithOne()
            .HasForeignKey<Ticket>(x => x.SeatId)
            .OnDelete(DeleteBehavior.NoAction)
            .IsRequired();

        builder.Property(m => m.Status)
        .IsRequired()
        .HasConversion<string>()
        .HasMaxLength(25);



    }


}
