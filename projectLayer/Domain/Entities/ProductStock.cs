using Core.Persistence.Repositories;

namespace projectLayer.Domain.Entities
{
    public class ProductStock:Entity
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