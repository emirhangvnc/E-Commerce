using Core.Persistence.Repositories;

namespace eCommerceLayer.Domain.Entities
{
    public class UserOperationClaim : Core.Security.Entities.UserOperationClaim, IEntity
    {
        public User User { get; set; }
    }
}