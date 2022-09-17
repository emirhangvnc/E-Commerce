using Core.Persistence.Repositories;
using eCommerceLayer.Domain.Entities.Base;

namespace eCommerceLayer.Domain.Entities
{
    public class ProductStock: BaseEntity, IEntity
    {
        public int ProductId { get; set; }
        public int UnitStock { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ProductStock(int id,int productId, int unitStock, DateTime updatedDate):base(id)
        {
            ProductId = productId;
            UnitStock = unitStock;
            UpdatedDate = updatedDate;
        }
    }
}