using Core.Persistence.Repositories;
using eCommerceLayer.Domain.Entities.Base;

namespace eCommerceLayer.Domain.Entities
{
    public class Feature: BaseEntity, IEntity
    {
        public string FeatureName { get; set; }
        public Feature(int id, string featureName) : base(id)
        {
            FeatureName = featureName;
        }
    }
}