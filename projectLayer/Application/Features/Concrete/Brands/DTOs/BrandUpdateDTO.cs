using Core.Persistence.Repositories;
using eCommerceLayer.Application.Features.Base.DTOs;

namespace eCommerceLayer.Application.Features.Concrete.Brands.DTOs
{
    public class BrandUpdateDTO : UpdateDTO, IDTO
    {
        public string BrandName { get; set; }
    }
}