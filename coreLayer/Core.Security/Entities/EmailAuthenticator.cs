using Core.Persistence.Repositories;
using Core.Security.Entities.Base;

namespace Core.Security.Entities
{
    public class EmailAuthenticator : IdBaseEntity,IEntity
    {
        public int UserId { get; set; }
        public string? ActivationKey { get; set; }
        public bool IsVerified { get; set; }

        public virtual User User { get; set; }
    }
}