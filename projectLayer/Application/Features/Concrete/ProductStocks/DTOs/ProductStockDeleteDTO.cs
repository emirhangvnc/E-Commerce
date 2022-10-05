using Core.Persistence.Repositories;

namespace eCommerceLayer.Application.Features.Concrete.ProductStocks.DTOs
{
    public class ProductStockDeleteDTO :IDTO
    {
        public int ProductId { get; set; }
    }
}