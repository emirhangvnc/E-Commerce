using Core.Persistence.Repositories;
using eCommerceLayer.Domain.Entities.Base;

namespace eCommerceLayer.Domain.Entities
{
    public class ProductFeature : BaseEntity, IEntity
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