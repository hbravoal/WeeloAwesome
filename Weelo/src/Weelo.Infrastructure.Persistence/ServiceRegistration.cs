using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Weelo.Application.Interfaces;
using Weelo.Application.Interfaces.Repositories;
using Weelo.Infrastructure.Persistence.Contexts;
using Weelo.Infrastructure.Persistence.Repositories;
using Weelo.Infrastructure.Persistence.Repository;

namespace Weelo.Infrastructure.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            if (configuration.GetValue<bool>("UseInMemoryDatabase"))
            {
                services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseInMemoryDatabase("ApplicationDb"));
            }
            else
            {
                services.AddDbContext<ApplicationDbContext>(options =>
               options.UseSqlServer(
                   configuration.GetConnectionString("DefaultConnection"),
                   b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
            }
            #region Repositories
            services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));
            services.AddTransient<IProductRepositoryAsync, ProductRepositoryAsync>();
            services.AddTransient<IPropertyRepositoryAsync, PropertyRepositoryAsync>();
            services.AddTransient<IPropertyImageRepositoryAsync, PropertyImageRepositoryAsync>();
            services.AddTransient<IOwnerRepositoryAsync, OwnerRepositoryAsync>();
            #endregion
        }
    }
}
