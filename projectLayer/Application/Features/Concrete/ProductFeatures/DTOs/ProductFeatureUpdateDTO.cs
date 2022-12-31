using Core.Persistence.Repositories;
using eCommerceLayer.Application.Features.Base.DTOs;

namespace eCommerceLayer.Application.Features.Concrete.ProductFeatures.DTOs
{
    public class ProductFeatureUpdateDTO : UpdateDTO, IDTO
    {
        public int ProductId { get; set; }
        public int FeatureValueId { get; set; }
    }
}