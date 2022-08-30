using coreLayer.Permanency.Repositories;

namespace projectLayer.Domain.Entities
{
    public class ProductStock:Entity
    {
        public int ProductId { get; set; }
        public int UnitStock { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ProductStock(int productId, int unitStock, DateTime updatedDate)
        {
            ProductId = productId;
            UnitStock = unitStock;
            UpdatedDate = updatedDate;
        }

        public ProductStock(int id,int productId, int unitStock, DateTime updatedDate) : this(productId, unitStock, updatedDate)
        {
            Id = id;
        }
    }
}