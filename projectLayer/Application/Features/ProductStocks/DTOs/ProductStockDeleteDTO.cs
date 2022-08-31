using Core.Persistence.Repositories;

namespace projectLayer.Application.Features.ProductStocks.DTOs
{
    public class ProductStockDeleteDTO :IDTO
    {
        public int ProductId { get; set; }
    }
}