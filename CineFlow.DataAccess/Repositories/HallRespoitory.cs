using CineFlow.Application.Abstractions.Persistance;
using CineFlow.Core.Entities;
using CineFlow.DataAccess.Persistance.ApplicationDb;

namespace CineFlow.DataAccess.Repositories;

public class HallRespoitory : GenericRepository<Hall>, IHallRepsitory
{
    public HallRespoitory(AppDbContext dbContext) : base(dbContext)
    {
    }
}
