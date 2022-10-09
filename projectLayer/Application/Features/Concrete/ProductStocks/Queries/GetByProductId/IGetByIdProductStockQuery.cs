using eCommerceLayer.Application.Features.Base.Abstract;
using eCommerceLayer.Application.Features.Concrete.ProductStocks.DTOs;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.ProductStocks.Queries.GetByProductId
{
    public interface IGetByProductIdQuery : IGetByIDService<ProductStock, ProductStockGetByIdDto>
    {
    }
}