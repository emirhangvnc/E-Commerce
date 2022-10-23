using eCommerceLayer.Application.Features.Base.Abstract.Commands;
using eCommerceLayer.Application.Features.Concrete.Products.DTOs;

namespace eCommerceLayer.Application.Features.Concrete.ProductStocks.Commands.UpdateProduct
{
    public interface IUpdateProductService : IUpdateService<ProductUpdateDTO>
    {
    }
}