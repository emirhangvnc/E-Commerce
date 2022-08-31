using Core.Persistence.Repositories;

namespace projectLayer.Domain.Entities
{
    public class Favorite : Entity
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public Favorite(int userId, int productId)
        {
            UserId = userId;
            ProductId = productId;
        }
    }
}