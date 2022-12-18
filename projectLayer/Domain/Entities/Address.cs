using Core.Persistence.Repositories;
using eCommerceLayer.Domain.Entities.Base;

namespace eCommerceLayer.Domain.Entities
{
    public class Address : BaseEntity, IEntity
    {
        public int DistrictId { get; set; }
        public District District { get; set; }
        public string AddressLine { get; set; }
        public int ZipCode { get; set; }
    }
}