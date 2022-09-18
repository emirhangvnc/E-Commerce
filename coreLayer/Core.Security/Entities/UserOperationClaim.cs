using Core.Persistence.Repositories;
using Core.Security.Entities.Base;

namespace Core.Security.Entities
{
    public class UserOperationClaim : IdBaseEntity
    {
        public int UserId { get; set; }
        public OperationClaim OperationClaim { get; set; }
        public int OperationClaimId { get; set; }

    }
}