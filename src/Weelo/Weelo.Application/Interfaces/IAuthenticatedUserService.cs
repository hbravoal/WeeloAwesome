using System;
using System.Collections.Generic;
using System.Text;

namespace Weelo.Application.Interfaces
{
    public interface IAuthenticatedUserService
    {
        string UserId { get; }
    }
}
