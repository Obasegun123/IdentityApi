using System.ComponentModel.DataAnnotations;

namespace IdentityApi.Models
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}