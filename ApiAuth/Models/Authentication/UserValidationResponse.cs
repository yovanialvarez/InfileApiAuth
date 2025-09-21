namespace ApiAuth.Models.Authentication
{
    public class UserValidationResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
        public LoginResponse Data { get; set; }
    }
}
