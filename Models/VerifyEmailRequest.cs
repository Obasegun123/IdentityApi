using System.ComponentModel.DataAnnotations;

namespace IdentityApi.Models
{
    public class VerifyEmailRequest
    {
        [Required]
        public string Token { get; set; }
    }
}