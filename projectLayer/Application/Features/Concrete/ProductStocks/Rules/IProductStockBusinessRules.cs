using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Base.Rules;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.ProductStocks.Rules
{
    public interface IProductStockBusinessRules:IIdNumberExistsService<ProductStock>
    {
    }
}