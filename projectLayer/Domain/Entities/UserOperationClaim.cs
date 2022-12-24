using Core.Persistence.Repositories;

namespace eCommerceLayer.Domain.Entities
{
    public class UserOperationClaim : Core.Security.Entities.UserOperationClaim, IEntity
    {
        public Customer Customer { get; set; }
    }
}