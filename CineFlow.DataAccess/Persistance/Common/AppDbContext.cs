using CineFlow.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CineFlow.DataAccess.Persistance.ApplicationDb;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Customer> Customers => Set<Customer>();
    public DbSet<Cinema> Cinemas => Set<Cinema>();
    public DbSet<ShowTime> ShowTimes => Set<ShowTime>();
    public DbSet<Seat> Seats => Set<Seat>();
    public DbSet<Hall> Halls => Set<Hall>();
    public DbSet<Ticket> Tickets => Set<Ticket>();
    public DbSet<Movie> Movies => Set<Movie>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }


}
