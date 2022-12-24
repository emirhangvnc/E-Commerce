using Core.Persistence.Repositories;

namespace eCommerceLayer.Application.Features.Concrete.Countries.DTOs
{
    public class CountryAddDTO : IDTO
    {
        public string CountryName { get; set; }
        public string? Alpha2Code { get; set; }
        public string? Alpha3Code { get; set; }
        public int? NumericCode { get; set; }
    }
}