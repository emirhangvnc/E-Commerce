using Core.Persistence.Repositories;
using eCommerceLayer.Domain.Entities.Base;

namespace eCommerceLayer.Domain.Entities
{
    public class Variant : BaseEntity, IEntity
    {
        public string VariantName { get; set; }
        public ICollection<VariantValue> VariantValues { get; set; }
    }
}