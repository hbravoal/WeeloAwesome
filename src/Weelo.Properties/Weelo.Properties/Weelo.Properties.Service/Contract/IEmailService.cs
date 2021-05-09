using System.Threading.Tasks;
using Weelo.Properties.Domain.Settings;

namespace Weelo.Properties.Service.Contract
{
    public interface IEmailService
    {
        Task SendEmailAsync(MailRequest mailRequest);

    }
}
