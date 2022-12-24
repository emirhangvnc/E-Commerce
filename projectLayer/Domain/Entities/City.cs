using Core.Persistence.Repositories;
using eCommerceLayer.Domain.Entities.Base;

namespace eCommerceLayer.Domain.Entities
{
    public class City:BaseEntity, IEntity
    {
        public Country Country { get; set; }
        public string CityName { get; set; }
        public int CountryId { get; set; }
        public string CityCode { get; set; }
        public ICollection<District> Districts { get; set; }
    }
}