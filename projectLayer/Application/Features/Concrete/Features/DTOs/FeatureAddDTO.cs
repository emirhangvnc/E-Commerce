using Core.Persistence.Repositories;

namespace eCommerceLayer.Application.Features.Concrete.Features.DTOs
{
    public class FeatureAddDTO : IDTO
    {
        public string FeatureName { get; set; }
    }
}