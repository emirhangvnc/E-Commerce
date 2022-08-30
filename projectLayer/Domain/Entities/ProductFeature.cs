using coreLayer.Permanency.Repositories;

namespace projectLayer.Domain.Entities
{
    public class ProductFeature : Entity
    {
        public int ProductId { get; set; }
        public int FeatureValueId { get; set; }
        public ProductFeature(int productId, int featureValueId)
        {
            ProductId = productId;
            FeatureValueId = featureValueId;
        }

        public ProductFeature(int id, int productId, int featureValueId) : this(productId, featureValueId)
        {
            Id = id;
        }
    }
}