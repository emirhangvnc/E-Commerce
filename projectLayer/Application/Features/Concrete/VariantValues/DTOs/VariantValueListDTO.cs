using Core.Persistence.Repositories;

namespace eCommerceLayer.Application.Features.Concrete.VariantValues.DTOs
{
    public class VariantValueListDTO : IDTO
    {
        public string VariantName { get; set; }
        public string Value { get; set; }
    }
}
