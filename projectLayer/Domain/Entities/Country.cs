using Core.Persistence.Repositories;
using eCommerceLayer.Domain.Entities.Base;

namespace eCommerceLayer.Domain.Entities
{
    public class Country : BaseEntity, IEntity
    {
        public string CountryName { get; set; }
        public string? Alpha2Code { get; set; }
        public string? Alpha3Code { get; set; }
        public int? NumericCode { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}