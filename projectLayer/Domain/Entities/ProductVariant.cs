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
        public string? VariantSku { get; set; }
        public string? VariantGtin { get; set; }
        public decimal? VariantPrice { get; set; }
    }
}