using Core.Persistence.Repositories;

namespace eCommerceLayer.Application.Features.Concrete.ProductStocks.DTOs
{
    public class ProductStockAddDTO : IDTO
    {
        public int ProductId { get; set; }
        public int UnitStock { get; set; }
    }
}