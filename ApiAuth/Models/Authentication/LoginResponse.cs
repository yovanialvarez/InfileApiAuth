namespace ApiAuth.Models.Authentication
{
    public class LoginResponse
    {
        public string Token { get; set; }
        public string Name { get; set; }
        public DateTime ExpiresAt { get; set; }
    }
}
