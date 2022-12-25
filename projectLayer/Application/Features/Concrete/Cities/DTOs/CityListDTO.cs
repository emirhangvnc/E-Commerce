using Core.Persistence.Repositories;

namespace eCommerceLayer.Application.Features.Concrete.Cities.DTOs
{
    public class CityListDTO : IDTO
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public string? CityCode { get; set; }
    }
}