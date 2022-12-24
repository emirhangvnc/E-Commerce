using Core.Persistence.Repositories;

namespace eCommerceLayer.Application.Features.Concrete.Brands.DTOs
{
    public class BrandAddDTO : IDTO
    {
        public string BrandName { get; set; }
    }
}