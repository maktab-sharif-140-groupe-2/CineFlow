using CineFlow.Core.Common;

namespace CineFlow.Application.Abstractions.Persistance;

public interface IUnitOfWork : IDisposable
{
    IGenericRepository<T> GetRepository<T>() where T : BaseEntity;

    ICinemaRepository CinemaRepository { get; }
    ICustomerRepository CustomerRepository { get; }
    IHallRepsitory HallRepsitory { get; }
    IMovieRepository MovieRepository { get; }
    ISeatRepository SeatRepository { get; }
    IShowTimeRepository ShowTimeRepository { get; }
    ITicketRepository TicketRepository { get; }

    Task<int> SaveChangesAsync();
}
