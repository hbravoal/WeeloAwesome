using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Weelo.Application.DTOs.Email;

namespace Weelo.Application.Interfaces
{
    public interface IEmailService
    {
        Task SendAsync(EmailRequest request);
    }
}
