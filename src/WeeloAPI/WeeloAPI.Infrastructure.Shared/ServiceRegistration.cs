using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WeeloAPI.Application.Interfaces;
using WeeloAPI.Domain.Settings;
using WeeloAPI.Infrastructure.Shared.Services;

namespace WeeloAPI.Infrastructure.Shared
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
