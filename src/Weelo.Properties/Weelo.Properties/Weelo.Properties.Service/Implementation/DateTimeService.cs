using System;
using Weelo.Properties.Service.Contract;

namespace Weelo.Properties.Service.Implementation
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}