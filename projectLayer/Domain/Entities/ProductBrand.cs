using coreLayer.Permanency.Repositories;

namespace projectLayer.Domain.Entities
{
    public class ProductBrand : Entity
    {
        public int ProductId { get; set; }
        public int BrandId { get; set; }
        public ProductBrand(int productId, int brandId)
        {
            ProductId = productId;
            BrandId = brandId;
        }

        public ProductBrand(int id, int productId, int brandId) : this(productId, brandId)
        {
            Id = id;
        }
    }
}