using eCommerceLayer.Application.Features.Base.DTOs;
using Core.Persistence.Repositories;

namespace eCommerceLayer.Application.Features.Concrete.FeatureValues.DTOs
{
    public class FeatureValueUpdateDTO : UpdateDTO, IDTO
    {
        public int FeatureId { get; set; }
        public string Value { get; set; }
    }
}