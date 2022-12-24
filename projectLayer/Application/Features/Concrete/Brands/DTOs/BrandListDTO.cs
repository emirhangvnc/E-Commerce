using Core.Persistence.Repositories;

namespace eCommerceLayer.Application.Features.Concrete.Brands.DTOs
{
    public class BrandListDTO : IDTO
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
    }
}
