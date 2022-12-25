using Core.Persistence.Repositories;
using eCommerceLayer.Application.Features.Base.DTOs;

namespace eCommerceLayer.Application.Features.Concrete.Cities.DTOs
{
    public class CityUpdateDTO : UpdateDTO, IDTO
    {
        public string CityName { get; set; }
        public int CountryId { get; set; }
        public string? CityCode { get; set; }
    }
}