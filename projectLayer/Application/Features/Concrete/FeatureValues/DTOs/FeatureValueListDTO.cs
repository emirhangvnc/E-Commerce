using Core.Persistence.Repositories;
using eCommerceLayer.Application.Features.Concrete.FeatureValues.Rules;

namespace eCommerceLayer.Application.Features.Concrete.FeatureValues.DTOs
{
    public class FeatureValueListDTO : IDTO
    {
        public string FeatureName { get; set; }
        public string Value { get; set; }
    }
}