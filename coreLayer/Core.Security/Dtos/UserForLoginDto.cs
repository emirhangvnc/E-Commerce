
namespace Core.Security.DTOs
{
    public class UserForLoginDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string AuthenticatorCode { get; set; }
    }
}