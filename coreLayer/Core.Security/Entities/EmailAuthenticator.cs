using Core.Security.Entities.Base;

namespace Core.Security.Entities
{
    public class EmailAuthenticator : IdBaseEntity
    {
        public User User { get; set; }
        public int UserId { get; set; }
        public string? ActivationKey { get; set; }
        public bool IsVerified { get; set; }

    }
}