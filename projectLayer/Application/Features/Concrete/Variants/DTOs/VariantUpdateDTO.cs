using Core.Persistence.Repositories;
using eCommerceLayer.Application.Features.Base.DTOs;

namespace eCommerceLayer.Application.Features.Concrete.Variants.DTOs
{
    public class VariantUpdateDTO : UpdateDTO, IDTO
    {
        public string VariantName { get; set; }
    }
}