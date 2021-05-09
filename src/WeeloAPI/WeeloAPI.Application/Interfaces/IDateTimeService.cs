using System;
using System.Collections.Generic;
using System.Text;

namespace WeeloAPI.Application.Interfaces
{
    public interface IDateTimeService
    {
        DateTime NowUtc { get; }
    }
}
