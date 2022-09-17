using Core.Persistence.Repositories;
using Core.Security.Entities.Base;

namespace Core.Security.Entities
{
    public class UserOperationClaim : IdBaseEntity, IEntity
    {
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }

        public virtual User User { get; set; }
        public virtual OperationClaim OperationClaim { get; set; }
    }
}