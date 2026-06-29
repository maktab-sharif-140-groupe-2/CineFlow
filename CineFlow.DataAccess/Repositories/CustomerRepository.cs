using CineFlow.Application.Abstractions.Persistance;
using CineFlow.Core.Entities;
using CineFlow.DataAccess.Persistance.ApplicationDb;

namespace CineFlow.DataAccess.Repositories;

public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
{
    public CustomerRepository(AppDbContext dbContext) : base(dbContext)
    {
    }
}
