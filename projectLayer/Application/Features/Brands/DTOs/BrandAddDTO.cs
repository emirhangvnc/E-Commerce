using Core.Persistence.Repositories;

namespace eCommerceLayer.Application.Features.Brands.DTOs
{
    public class BrandAddDTO : IDTO
    {
        public string BrandName { get; set; }
    }
}