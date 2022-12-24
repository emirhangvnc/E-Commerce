using Core.Persistence.Repositories;
using eCommerceLayer.Domain.Entities.Base;

namespace eCommerceLayer.Domain.Entities
{
    public class Order : BaseEntity, IEntity
    {
        public User User { get; set; }
        public int UserId { get; set; }
        public Address Address { get; set; }
        public int AddressId { get; set; }
        public decimal? TotalPrice { get; set; }
        public int? TotalItem { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}