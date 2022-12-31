using Core.Persistence.Repositories;

namespace eCommerceLayer.Application.Features.Concrete.Variants.DTOs
{
    public class VariantAddDTO : IDTO
    {
        public string VariantName { get; set; }
    }
}