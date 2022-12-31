using Core.Persistence.Repositories;

namespace eCommerceLayer.Application.Features.Concrete.Variants.DTOs
{
    public class VariantListDTO : IDTO
    {
        public int Id { get; set; }
        public string VariantName { get; set; }
    }
}
