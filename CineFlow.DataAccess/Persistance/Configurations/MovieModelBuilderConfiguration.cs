using CineFlow.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CineFlow.DataAccess.Persistance.Configurations;

public class MovieModelBuilderConfiguration : BaseModelBuilderConfiguration<Movie>
{
    protected override void ApplyEntityConfiguration(EntityTypeBuilder<Movie> builder)
    {
        builder.Property(m => m.Title)
            .IsRequired()
            .HasMaxLength(25);

        builder.Property(m => m.Description)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(m => m.Genre)
            .IsRequired()
            .HasConversion<string>()
            .HasMaxLength(25);

        builder.HasMany(m => m.Shows)
            .WithOne(st =>  st.Movie)
            .HasForeignKey(st => st.MovieId)
            .OnDelete(DeleteBehavior.Restrict)
            .IsRequired();
    }
}
