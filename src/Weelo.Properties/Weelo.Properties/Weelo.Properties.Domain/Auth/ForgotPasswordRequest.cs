using System.ComponentModel.DataAnnotations;

namespace Weelo.Properties.Domain.Auth
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
