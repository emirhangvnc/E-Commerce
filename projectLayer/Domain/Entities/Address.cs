using Core.Persistence.Repositories;
using eCommerceLayer.Domain.Entities.Base;

namespace eCommerceLayer.Domain.Entities
{
    public class Address : BaseEntity, IEntity
    {
        public string AddressTitle { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int DistrictId { get; set; }
        public District District { get; set; }
        public string AddressLine { get; set; }
        public int? ZipCode { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}