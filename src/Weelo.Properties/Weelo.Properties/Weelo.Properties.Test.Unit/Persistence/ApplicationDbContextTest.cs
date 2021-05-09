using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using Weelo.Properties.Domain.Entities;
using Weelo.Properties.Persistence;

namespace Weelo.Properties.Test.Unit.Persistence
{
    public class ApplicationDbContextTest
    {
        [Test]
        public void CanInsertCustomerIntoDatabasee()
        {

            using var context = new ApplicationDbContext();
            var customer = new Customer();
            context.Customers.Add(customer);
            Assert.AreEqual(EntityState.Added, context.Entry(customer).State);
        }
    }
}
