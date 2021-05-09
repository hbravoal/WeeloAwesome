using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Weelo.Application.Interfaces;
using Weelo.Domain.Settings;
using Weelo.Infrastructure.Shared.Services;

namespace Weelo.Infrastructure.Shared
{
    public static class ServiceRegistration
    {
        public static void AddSharedInfrastructure(this IServiceCollection services, IConfiguration _config)
        {
            services.Configure<MailSettings>(_config.GetSection("MailSettings"));
            services.AddTransient<IDateTimeService, DateTimeService>();
            services.AddTransient<IEmailService, EmailService>();
        }
    }
}
