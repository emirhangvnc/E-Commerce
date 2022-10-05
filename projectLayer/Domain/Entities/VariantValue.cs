using Core.Persistence.Repositories;
using eCommerceLayer.Domain.Entities.Base;

namespace eCommerceLayer.Domain.Entities
{
    public class VariantValue : BaseEntity, IEntity
    {
        public Variant Variant { get; set; }
        public int VariantId { get; set; }
        public string Value { get; set; }
        public ICollection<ProductVariant> ProductVariants { get; set; }
    }
}