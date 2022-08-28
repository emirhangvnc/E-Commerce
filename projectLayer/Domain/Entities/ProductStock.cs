using coreLayer.Persistence.Repositories;

namespace projectLayer.Domain.Entities
{
    public class ProductStock:Entity
    {
        public int UnitStock { get; set; }

        public ProductStock(int unitStock)
        {
            UnitStock = unitStock;
        }

        public ProductStock(int id, int unitStock) : this(unitStock)
        {
            Id = id;
        }
    }
}