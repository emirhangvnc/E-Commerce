using Core.Persistence.Repositories;

namespace eCommerceLayer.Application.Features.Concrete.ProductStocks.DTOs
{
    public class ProductStockListDTO : IDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}