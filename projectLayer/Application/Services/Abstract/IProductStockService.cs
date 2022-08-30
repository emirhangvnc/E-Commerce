using projectLayer.Application.Features.ProductStocks.DTOs;
using projectLayer.Application.Services.Abstract.Base;
using projectLayer.Domain.Entities;

namespace projectLayer.Application.Services.Abstract
{
    public interface IProductStockService : IBaseService<ProductStock,
        ProductStockAddDTO, ProductStockDeleteDTO, ProductStockUpdateDTO>
    {
    }
}