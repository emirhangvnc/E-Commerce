using coreLayer.Permanency.Repositories;

namespace projectLayer.Domain.Entities
{
    public class Feature:Entity
    {
        public string FeatureName { get; set; }
        public Feature(string featureName)
        {
            FeatureName = featureName;
        }

        public Feature(int id, string featureName):this(featureName)
        {
            Id = id;
        }
    }
}