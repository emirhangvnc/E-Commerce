using Core.Persistence.Repositories;
using eCommerceLayer.Domain.Entities.Base;

namespace eCommerceLayer.Domain.Entities
{
    public class District : BaseEntity, IEntity
    {
        public City City { get; set; }
        public int CityId { get; set; }
        public string DistrictName { get; set; }
        public ICollection<Address> Addresses { get; set; }
    }
}