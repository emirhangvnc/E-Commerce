using eCommerceLayer.Application.Features.Base.DTOs;
using Core.Persistence.Repositories;

namespace eCommerceLayer.Application.Features.Concrete.Features.DTOs
{
    public class FeatureUpdateDTO : UpdateDTO, IDTO
    {
        public string FeatureName { get; set; }
        public FeatureUpdateDTO(string featureName)
        {
            FeatureName = featureName;
        }
    }
}