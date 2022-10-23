using eCommerceLayer.Application.Features.Base.Abstract.Commands;
using eCommerceLayer.Application.Features.Concrete.Products.DTOs;

namespace eCommerceLayer.Application.Features.Concrete.ProductStocks.Commands.AddProduct
{
    public interface IAddProductService : IAddService<ProductAddDTO>
    {
    }
}