using CineFlow.Application.Abstractions.Persistance;
using CineFlow.Core.Common;
using CineFlow.DataAccess.Persistance.ApplicationDb;

namespace CineFlow.DataAccess.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    private readonly Dictionary<Type, object> _repositories = new Dictionary<Type, object>();

    public UnitOfWork(AppDbContext context)
    {
        _context = context;

        CinemaRepository = new CinemaRepository(_context);
        CustomerRepository = new CustomerRepository(_context);
        HallRepsitory = new HallRespoitory(_context);
        MovieRepository = new MovieRepository(_context);
        SeatRepository = new SeatRepository(_context);
        ShowTimeRepository = new ShowTimeRepository(_context);
        TicketRepository = new TicketRepository(_context);
    }

    public ICinemaRepository CinemaRepository { get; }

    public ICustomerRepository CustomerRepository { get; }

    public IHallRepsitory HallRepsitory { get; }

    public IMovieRepository MovieRepository { get; }

    public ISeatRepository SeatRepository { get; }

    public IShowTimeRepository ShowTimeRepository { get; }

    public ITicketRepository TicketRepository { get; }

    public void Dispose()
    {
        _context.Dispose();
    }

    public IGenericRepository<T> GetRepository<T>() where T : BaseEntity
    {
        var type = typeof(T);

        if (!_repositories.ContainsKey(type))
        {
            var repoistory = new GenericRepository<T>(_context);

            _repositories.Add(type, repoistory);
        }

        return (IGenericRepository<T>)_repositories[typeof(T)];
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
}
