using Core.Persistence.Repositories;
using eCommerceLayer.Domain.Entities.Base;

namespace eCommerceLayer.Domain.Entities
{
    public class Country : BaseEntity, IEntity
    {
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public string ISOCode { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}