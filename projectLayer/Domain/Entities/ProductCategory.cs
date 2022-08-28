using coreLayer.Persistence.Repositories;

namespace projectLayer.Domain.Entities
{
    public class ProductCategory: Entity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public ProductCategory(int productId,int categoryId)
        {
            ProductId = productId;
            CategoryId = categoryId;
        }
    }
}