using Core.Persistence.Repositories;

namespace projectLayer.Domain.Entities
{
    public class Feature:Entity
    {
        public string FeatureName { get; set; }
        public Feature(int id, string featureName) : base(id)
        {
            FeatureName = featureName;
        }
    }
}