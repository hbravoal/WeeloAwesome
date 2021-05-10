using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using Weelo.Domain.Entities;
using Weelo.Infrastructure.Persistence.Contexts;

namespace Weelo.Test.Unit.Persistence
{
    public class ApplicationDbContextTest
    {
        [Test]
        public void CanInsertCustomerIntoDatabasee()
        {

            using var context = new ApplicationDbContext();
            var property = new Property();
            context.Properties.Add(property);
            Assert.AreEqual(EntityState.Added, context.Entry(property).State);
        }
    }
}
