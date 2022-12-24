using Core.Security.Entities.Base;
using Core.Security.Enums;

namespace Core.Security.Entities
{
    public class User : IdBaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public bool? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public AuthenticatorType AuthenticatorType { get; set; }

        public ICollection<OtpAuthenticator> OtpAuthenticators { get; set; }
        public ICollection<EmailAuthenticator> EmailAuthenticators { get; set; }
        public ICollection<RefreshToken> RefreshTokens { get; set; }
    }
}