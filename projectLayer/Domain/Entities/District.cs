using Core.Persistence.Repositories;
using eCommerceLayer.Domain.Entities.Base;

namespace eCommerceLayer.Domain.Entities
{
    public class District : BaseEntity, IEntity
    {
        public int CityId { get; set; }
        public City City { get; set; }
        public string DistrictName { get; set; }
        public ICollection<Address> Addresses { get; set; }
    }
}