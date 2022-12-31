using Core.Persistence.Repositories;

namespace eCommerceLayer.Application.Features.Concrete.ProductFeatures.DTOs
{
    public class ProductFeatureAddDTO : IDTO
    {
        public int ProductId { get; set; }
        public int FeatureValueId { get; set; }
    }
}