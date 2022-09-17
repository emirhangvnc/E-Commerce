using eCommerceLayer.Application.Features.ProductStocks.DTOs;
using eCommerceLayer.Application.Services.Abstract.Base;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Services.Abstract
{
    public interface IProductStockService : IBaseService<ProductStock,
        ProductStockAddDTO, ProductStockDeleteDTO, ProductStockUpdateDTO>
    {
    }
}