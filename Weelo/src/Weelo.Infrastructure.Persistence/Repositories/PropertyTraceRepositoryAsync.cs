using Microsoft.EntityFrameworkCore;
using Weelo.Application.Interfaces.Repositories;
using Weelo.Domain.Entities;
using Weelo.Infrastructure.Persistence.Contexts;
using Weelo.Infrastructure.Persistence.Repository;
using System.Threading.Tasks;

namespace Weelo.Infrastructure.Persistence.Repositories
{
    public class PropertyTraceRepositoryAsync : GenericRepositoryAsync<PropertyTrace>, IPropertyTraceRepositoryAsync
    {
        private readonly DbSet<PropertyTrace> _repository;

        public PropertyTraceRepositoryAsync(ApplicationDbContext dbContext) : base(dbContext)
        {
            //_repository = dbContext.Set<Owner>();
        }


    }
}