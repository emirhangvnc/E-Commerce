using eCommerceLayer.Application.Features.Base.DTOs;
using Core.Persistence.Repositories;

namespace eCommerceLayer.Application.Features.Brands.DTOs
{
    public class BrandUpdateDTO : UpdateDTO, IDTO
    {
        public string BrandName { get; set; }
    }
}