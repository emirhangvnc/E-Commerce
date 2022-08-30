using coreLayer.Permanency.Repositories;

namespace projectLayer.Application.Features.ProductStocks.DTOs
{
    public class ProductStockDeleteDTO :IDTO
    {
        public int ProductId { get; set; }
    }
}