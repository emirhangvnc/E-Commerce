using Core.Persistence.Repositories;

namespace eCommerceLayer.Application.Features.Concrete.Cities.DTOs
{
    public class CityAddDTO : IDTO
    {
        public string CityName { get; set; }
        public int CountryId { get; set; }
        public string? CityCode { get; set; }
    }
}