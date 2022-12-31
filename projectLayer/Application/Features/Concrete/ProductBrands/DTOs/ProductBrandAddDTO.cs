using Core.Persistence.Repositories;

namespace eCommerceLayer.Application.Features.Concrete.ProductBrands.DTOs
{
    public class ProductBrandAddDTO : IDTO
    {
        public int ProductId { get; set; }
        public int BrandId { get; set; }
    }
}