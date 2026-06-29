using CineFlow.Application.Abstractions.Persistance;
using CineFlow.Core.Entities;
using CineFlow.DataAccess.Persistance.ApplicationDb;

namespace CineFlow.DataAccess.Repositories;

public class MovieRepository : GenericRepository<Movie>, IMovieRepository
{
    public MovieRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}
