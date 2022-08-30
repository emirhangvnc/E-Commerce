using coreLayer.Permanency.Repositories;

namespace projectLayer.Domain.Entities
{
    public class ProductStock:Entity
    {
        public int ProductId { get; set; }
        public int UnitStock { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ProductStock(int id,int productId, int unitStock, DateTime updatedDate)
        {
            ProductId = productId;
            UnitStock = unitStock;
            UpdatedDate = updatedDate;
        }
    }
}