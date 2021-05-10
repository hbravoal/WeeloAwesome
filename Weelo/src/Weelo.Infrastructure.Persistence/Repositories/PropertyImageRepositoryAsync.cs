using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Weelo.Application.Interfaces.Repositories;
using Weelo.Domain.Entities;
using Weelo.Infrastructure.Persistence.Contexts;
using Weelo.Infrastructure.Persistence.Repository;

namespace Weelo.Infrastructure.Persistence.Repositories
{
    public class PropertyImageRepositoryAsync : GenericRepositoryAsync<PropertyImage>, IPropertyImageRepositoryAsync
    {
        private readonly DbSet<PropertyImage> _products;

        public PropertyImageRepositoryAsync(ApplicationDbContext dbContext) : base(dbContext)
        {
            _products = dbContext.Set<PropertyImage>();
        }

      
    }
}
