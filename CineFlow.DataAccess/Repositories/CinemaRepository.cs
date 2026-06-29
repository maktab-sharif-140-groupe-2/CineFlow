using CineFlow.Application.Abstractions.Persistance;
using CineFlow.Core.Entities;
using CineFlow.DataAccess.Persistance.ApplicationDb;

namespace CineFlow.DataAccess.Repositories;

public class CinemaRepository : GenericRepository<Cinema>, ICinemaRepository
{
    public CinemaRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}
