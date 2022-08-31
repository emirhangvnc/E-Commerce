using Core.Persistence.Repositories;

namespace projectLayer.Domain.Entities
{
    public class UserOperationClaim : Entity
    {
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }

        public UserOperationClaim(int userId,int operationClaimId)
        {
            UserId = userId;
            OperationClaimId = operationClaimId;
        }

        public UserOperationClaim(int id, int userId, int operationClaimId) : this(userId,operationClaimId)
        {
            Id = id;
        }
    }
}