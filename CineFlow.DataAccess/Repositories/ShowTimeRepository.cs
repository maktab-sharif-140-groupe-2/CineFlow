using CineFlow.Application.Abstractions.Persistance;
using CineFlow.Core.Entities;
using CineFlow.DataAccess.Persistance.ApplicationDb;

namespace CineFlow.DataAccess.Repositories;

public class ShowTimeRepository : GenericRepository<ShowTime>, IShowTimeRepository
{
    public ShowTimeRepository(AppDbContext dbContext) : base(dbContext)
    {
    }


}
