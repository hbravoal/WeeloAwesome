using Microsoft.EntityFrameworkCore;
using Weelo.Application.Interfaces.Repositories;
using Weelo.Domain.Entities;
using Weelo.Infrastructure.Persistence.Contexts;
using Weelo.Infrastructure.Persistence.Repository;

namespace Weelo.Infrastructure.Persistence.Repositories
{
    public class PropertyRepositoryAsync : GenericRepositoryAsync<Property>, IPropertyRepositoryAsync
    {
        private readonly DbSet<Property> _repository;

        public PropertyRepositoryAsync(ApplicationDbContext dbContext) : base(dbContext)
        {
            //_repository = dbContext.Set<Owner>();
        }


    }
}