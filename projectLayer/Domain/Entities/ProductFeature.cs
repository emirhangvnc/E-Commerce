using Core.Persistence.Repositories;

namespace projectLayer.Domain.Entities
{
    public class ProductFeature : Entity
    {
        public int ProductId { get; set; }
        public int FeatureValueId { get; set; }
        public ProductFeature(int id,int productId, int featureValueId):base(id)
        {
            ProductId = productId;
            FeatureValueId = featureValueId;
        }
    }
}