using Core.Persistence.Repositories;

namespace projectLayer.Domain.Entities
{
    public class FeatureValue : Entity
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