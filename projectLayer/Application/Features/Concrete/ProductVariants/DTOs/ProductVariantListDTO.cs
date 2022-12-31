using Core.Persistence.Repositories;

namespace eCommerceLayer.Application.Features.Concrete.ProductVariants.DTOs
{
    public class ProductVariantListDTO : IDTO
    {
        public int ProductId { get; set; }
        public int VariantId { get; set; }
    }
}
