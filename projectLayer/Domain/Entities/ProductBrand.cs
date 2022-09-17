using Core.Persistence.Repositories;
using eCommerceLayer.Domain.Entities.Base;

namespace eCommerceLayer.Domain.Entities
{
    public class ProductBrand : BaseEntity, IEntity
    {
        public int ProductId { get; set; }
        public int BrandId { get; set; }
        public ProductBrand(int id,int productId, int brandId):base(id)
        {
            ProductId = productId;
            BrandId = brandId;
        }
    }
}