using CineFlow.Application.Abstractions.Persistance;
using CineFlow.Core.Entities;
using CineFlow.DataAccess.Persistance.ApplicationDb;

namespace CineFlow.DataAccess.Repositories;

public class SeatRepository : GenericRepository<Seat>, ISeatRepository
{
    public SeatRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}
