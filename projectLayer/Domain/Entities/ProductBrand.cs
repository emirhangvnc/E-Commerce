using Core.Persistence.Repositories;

namespace projectLayer.Domain.Entities
{
    public class ProductBrand : Entity
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