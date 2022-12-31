using Core.Persistence.Repositories;
using eCommerceLayer.Application.Features.Base.DTOs;

namespace eCommerceLayer.Application.Features.Concrete.ProductVariants.DTOs
{
    public class ProductVariantUpdateDTO : UpdateDTO, IDTO
    {
        public int ProductId { get; set; }
        public int VariantValueId { get; set; }
        public string? VariantSku { get; set; }
        public string? VariantGtin { get; set; }
        public decimal? VariantPrice { get; set; }
    }
}