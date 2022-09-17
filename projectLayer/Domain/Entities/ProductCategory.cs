using Core.Persistence.Repositories;
using eCommerceLayer.Domain.Entities.Base;

namespace eCommerceLayer.Domain.Entities
{
    public class ProductCategory: BaseEntity, IEntity
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