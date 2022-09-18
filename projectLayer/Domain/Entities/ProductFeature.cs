using Core.Persistence.Repositories;
using eCommerceLayer.Domain.Entities.Base;

namespace eCommerceLayer.Domain.Entities
{
    public class ProductFeature : BaseEntity, IEntity
    {
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public FeatureValue FeatureValue { get; set; }
        public int FeatureValueId { get; set; }
    }
}