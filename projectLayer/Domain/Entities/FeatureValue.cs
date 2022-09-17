using Core.Persistence.Repositories;
using eCommerceLayer.Domain.Entities.Base;

namespace eCommerceLayer.Domain.Entities
{
    public class FeatureValue : BaseEntity, IEntity
    {
        public int FeatureId { get; set; }
        public string Value { get; set; }
        public FeatureValue(int id, int featureId, string value):base(id)
        {
            FeatureId = featureId;
            Value = value;
        }
    }
}