using Core.Persistence.Repositories;
using eCommerceLayer.Application.Features.Base.DTOs;

namespace eCommerceLayer.Application.Features.Concrete.VariantValues.DTOs
{
    public class VariantValueUpdateDTO : UpdateDTO, IDTO
    {
        public int VariantId { get; set; }
        public string Value { get; set; }
    }
}