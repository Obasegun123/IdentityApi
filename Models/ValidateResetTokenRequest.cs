using System.ComponentModel.DataAnnotations;

namespace IdentityApi.Models
{
    public class ValidateResetTokenRequest
    {
        [Required]
        public string Token { get; set; }
    }
}