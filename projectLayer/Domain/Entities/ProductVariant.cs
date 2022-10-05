using Core.Persistence.Repositories;
using eCommerceLayer.Domain.Entities.Base;

namespace eCommerceLayer.Domain.Entities
{
    public class ProductVariant : BaseEntity, IEntity
    {
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public VariantValue VariantValue { get; set; }
        public int VariantValueId { get; set; }
    }
}