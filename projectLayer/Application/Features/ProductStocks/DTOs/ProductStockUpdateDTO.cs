using coreLayer.Permanency.Paging;
using coreLayer.Permanency.Repositories;

namespace projectLayer.Application.Features.ProductStocks.DTOs
{
    public class ProductStockUpdateDTO : UpdateDTO, IDTO
    {
        public int ProductId { get; set; }
        public int UnitStock { get; set; }
        public ProductStockUpdateDTO(int productId, int unitStock)
        {
            ProductId = productId;
            UnitStock = unitStock;
        }
        public ProductStockUpdateDTO(int id,int productId, int unitStock) : this(productId, unitStock)
        {
            Id = id;
        }
    }
}