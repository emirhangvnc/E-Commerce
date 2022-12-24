using Core.Persistence.Repositories;
using eCommerceLayer.Application.Features.Base.DTOs;

namespace eCommerceLayer.Application.Features.Concrete.Countries.DTOs
{
    public class CountryUpdateDTO : UpdateDTO, IDTO
    {
        public string CountryName { get; set; }
        public string? Alpha2Code { get; set; }
        public string? Alpha3Code { get; set; }
        public int? NumericCode { get; set; }
    }
}