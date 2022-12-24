using Core.Persistence.Repositories;
using eCommerceLayer.Domain.Entities.Base;

namespace eCommerceLayer.Domain.Entities
{
    public class OrderItem : BaseEntity, IEntity
    {
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public Order Order { get; set; }
        public int? OrderId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}