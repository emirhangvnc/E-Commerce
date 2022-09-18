using Core.Persistence.Repositories;
using eCommerceLayer.Domain.Entities.Base;

namespace eCommerceLayer.Domain.Entities
{
    public class FeatureValue : BaseEntity, IEntity
    {
        public Feature Feature { get; set; }
        public int FeatureId { get; set; }
        public string Value { get; set; }
        public ICollection<ProductFeature> ProductFeatures { get; set; }
    }
}