using coreLayer.Permanency.Repositories;

namespace projectLayer.Domain.Entities
{
    public class FeatureValue : Entity
    {
        public int FeatureId { get; set; }
        public string Value { get; set; }
        public FeatureValue(int featureId, string value)
        {
            FeatureId = featureId;
            Value = value;
        }

        public FeatureValue(int id, int featureId, string value) : this(featureId, value)
        {
            Id = id;
        }
    }
}