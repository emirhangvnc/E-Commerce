using Core.Persistence.Repositories;

namespace eCommerceLayer.Application.Features.Concrete.Features.DTOs
{
    public class FeatureListDTO : IDTO
    {
        public int Id { get; set; }
        public string FeatureName { get; set; }
    }
}