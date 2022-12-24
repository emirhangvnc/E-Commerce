using Core.Persistence.Repositories;
using eCommerceLayer.Domain.Entities.Base;

namespace eCommerceLayer.Domain.Entities
{
    public class ProductStock: BaseEntity, IEntity
    {
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public int UnitStock { get; set; }
        public string? Description { get; set; }
    }
}