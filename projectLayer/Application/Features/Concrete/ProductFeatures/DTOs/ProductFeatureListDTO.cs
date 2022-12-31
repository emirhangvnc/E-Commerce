using Core.Persistence.Repositories;

namespace eCommerceLayer.Application.Features.Concrete.ProductFeatures.DTOs
{
    public class ProductFeatureListDTO : IDTO
    {
        public int ProductId { get; set; }
        public int FeatureValueId { get; set; }
    }
}