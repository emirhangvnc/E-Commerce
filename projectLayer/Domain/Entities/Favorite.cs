using Core.Persistence.Repositories;
using Core.Security.Entities;
using eCommerceLayer.Domain.Entities.Base;
using System.Reflection.Metadata;

namespace eCommerceLayer.Domain.Entities
{
    public class Favorite : BaseEntity, IEntity
    {
        public User User { get; set; }
        public int UserId { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}