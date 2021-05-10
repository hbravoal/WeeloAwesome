using System;
using System.Linq;
using System.Threading.Tasks;

namespace Weelo.Infrastructure.Persistence.Seeds
{
    public static class OwnerDefault
    {

        public static async Task SeedAsync(Application.Interfaces.Repositories.IOwnerRepositoryAsync context)
        {
            //Seed Default User
            var s = await context.GetAllAsync();
            if (!s.Any())
            {
                await context.AddAsync(new Domain.Entities.Owner
                {
                    Created = DateTime.Now,
                    CreatedBy = "Inicializer",
                    Name = "Henry Bravo",
                    Photo="ThisIsAUrl",
                    Birthday=DateTime.Now,
                    Address="Calle 77CA # 88-30"

                });


            }


        }
    }
}