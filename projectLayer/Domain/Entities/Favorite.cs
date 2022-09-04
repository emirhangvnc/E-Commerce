using Core.Persistence.Repositories;
using Core.Security.Entities;
using System.Reflection.Metadata;

namespace projectLayer.Domain.Entities
{
    public class Favorite : Entity
    {
        public User User { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public Favorite(int id, int userId, int productId) : base(id)
        {
            UserId = userId;
            ProductId = productId;
        }
    }
}