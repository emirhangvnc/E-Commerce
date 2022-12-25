using Core.Persistence.Repositories;

namespace eCommerceLayer.Application.Features.Concrete.FeatureValues.DTOs
{
    public class FeatureValueListDTO : IDTO
    {
        public string FeatureName { get; set; }
        public string Value { get; set; }
    }
}