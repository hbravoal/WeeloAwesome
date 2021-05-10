using Microsoft.EntityFrameworkCore;
using Weelo.Application.Interfaces.Repositories;
using Weelo.Domain.Entities;
using Weelo.Infrastructure.Persistence.Contexts;
using Weelo.Infrastructure.Persistence.Repository;

namespace Weelo.Infrastructure.Persistence.Repositories
{
    public class OwnerRepositoryAsync : GenericRepositoryAsync<Owner>, IOwnerRepositoryAsync
    {
        private readonly DbSet<Owner> _repository;

        public OwnerRepositoryAsync(ApplicationDbContext dbContext) : base(dbContext)
        {
            //_repository = dbContext.Set<Owner>();
        }

     
    }
}