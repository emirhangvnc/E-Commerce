using Core.Security.Entities.Base;

namespace Core.Security.Entities
{
    public class OperationClaim : IdBaseEntity
    {
        public string Name { get; set; }
        public ICollection<UserOperationClaim> UserOperationClaims { get; set; }
    }
}