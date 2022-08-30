using coreLayer.Permanency.Repositories;

namespace projectLayer.Application.Features.ProductStocks.DTOs
{
    public class ProductStockAddDTO : IDTO
    {
        public int ProductId { get; set; }
        public int UnitStock { get; set; }
    }
}