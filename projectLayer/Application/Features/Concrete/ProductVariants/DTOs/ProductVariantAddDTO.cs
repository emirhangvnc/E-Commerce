using Core.Persistence.Repositories;

namespace eCommerceLayer.Application.Features.Concrete.ProductVariants.DTOs
{
    public class ProductVariantAddDTO : IDTO
    {
        public int ProductId { get; set; }
        public int VariantValueId { get; set; }
        public string? VariantSku { get; set; }
        public string? VariantGtin { get; set; }
        public decimal? VariantPrice { get; set; }
    }
}