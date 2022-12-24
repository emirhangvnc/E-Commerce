using Core.Persistence.Repositories;

namespace eCommerceLayer.Application.Features.Concrete.Countries.DTOs
{
    public class CountryListDTO : IDTO
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
    }
}