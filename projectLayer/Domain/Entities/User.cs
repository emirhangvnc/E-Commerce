using Core.Persistence.Repositories;

namespace eCommerceLayer.Domain.Entities
{
    public class User:Core.Security.Entities.User,IEntity
    {
        public ICollection<Favorite> Favorites { get; set; }
        public ICollection<UserOperationClaim> UserOperationClaims { get; set; }

    }
}