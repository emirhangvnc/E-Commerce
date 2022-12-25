using Core.Persistence.Repositories;

namespace eCommerceLayer.Application.Features.Concrete.FeatureValues.DTOs
{
    public class FeatureValueAddDTO : IDTO
    {
        public int FeatureId { get; set; }
        public string Value { get; set; }
    }
}