using Core.Persistence.Repositories;

namespace eCommerceLayer.Application.Features.Concrete.VariantValues.DTOs
{
    public class VariantValueAddDTO : IDTO
    {
        public int VariantId { get; set; }
        public string Value { get; set; }
    }
}