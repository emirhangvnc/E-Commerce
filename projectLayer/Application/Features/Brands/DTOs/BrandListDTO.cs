using Core.Persistence.Repositories;

namespace projectLayer.Application.Features.Brands.DTOs
{
    public class BrandListDTO:IDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}