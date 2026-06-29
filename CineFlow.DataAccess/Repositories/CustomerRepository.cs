<<<<<<< Updated upstream
﻿using CineFlow.Application.Abstractions.Persistance;
using CineFlow.Core.Entities;
using CineFlow.DataAccess.Persistance.ApplicationDb;
=======
﻿using CineFlow.Application.Abstractions.Exception;
using CineFlow.Application.Abstractions.Persistance;
using CineFlow.Core.Entities;
using CineFlow.DataAccess.Persistance.ApplicationDb;
using Microsoft.EntityFrameworkCore;
>>>>>>> Stashed changes

namespace CineFlow.DataAccess.Repositories;

public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
{
    public CustomerRepository(AppDbContext dbContext) : base(dbContext)
    {
    }

}
