using System.ComponentModel.DataAnnotations;

namespace ApiAuth.Models.Authentication
{
    public class UserValidationRequest
    {
        [Required]
        public string Username { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
    }
}
