using Core.Persistence.Repositories;
using Core.Security.Entities;

namespace eCommerceLayer.Domain.Entities
{
    public class Customer:User,IEntity
    {
        public ICollection<Favorite> Favorites { get; set; }
        public ICollection<UserOperationClaim> UserOperationClaims { get; set; }

    }
}