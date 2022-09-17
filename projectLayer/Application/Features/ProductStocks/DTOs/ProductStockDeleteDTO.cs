using Core.Persistence.Repositories;

namespace eCommerceLayer.Application.Features.ProductStocks.DTOs
{
    public class ProductStockDeleteDTO :IDTO
    {
        public int ProductId { get; set; }
    }
}