using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeeloAPI.Application.DTOs.Email;

namespace WeeloAPI.Application.Interfaces
{
    public interface IEmailService
    {
        Task SendAsync(EmailRequest request);
    }
}
