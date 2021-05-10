using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.Configuration;

namespace Weelo.Application.Services
{
    public class DataProtectionHelper : IDataProtectionHelper
    {
        private readonly IDataProtectionProvider
           _dataProtectionProvider;

        public IConfiguration Configuration { get; }

        public DataProtectionHelper(IDataProtectionProvider
            dataProtectionProvider, IConfiguration configuration)
        {
            _dataProtectionProvider = dataProtectionProvider;
            Configuration = configuration;
        }
        public string Encrypt(string textToEncrypt)
        {
            return _dataProtectionProvider.CreateProtector(Configuration["JWTSettings:Key"]).
            Protect(textToEncrypt);
        }
        public string Decrypt(string cipherText)
        {
            return _dataProtectionProvider.CreateProtector(Configuration["JWTSettings:Key"]).
            Unprotect(cipherText);
        }
    }
}
