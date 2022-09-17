using Core.Persistence.Repositories;
using Core.Security.Entities.Base;

namespace Core.Security.Entities
{
    public class OtpAuthenticator : IdBaseEntity, IEntity
    {
        public int UserId { get; set; }
        public byte[] SecretKey { get; set; }
        public bool IsVerified { get; set; }

        public virtual User User { get; set; }
    }
}