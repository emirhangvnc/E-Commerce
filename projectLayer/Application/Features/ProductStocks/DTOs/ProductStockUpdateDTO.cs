using coreLayer.Permanency.Paging;
using coreLayer.Permanency.Repositories;

namespace projectLayer.Application.Features.ProductStocks.DTOs
{
    public class ProductStockUpdateDTO : IDTO
    {
        public int ProductId { get; set; }
        public int UnitStock { get; set; }
    }
}