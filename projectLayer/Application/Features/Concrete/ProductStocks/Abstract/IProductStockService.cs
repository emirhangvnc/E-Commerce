using eCommerceLayer.Application.Features.Concrete.ProductStocks.Commands.AddProductStock;
using eCommerceLayer.Application.Features.Concrete.ProductStocks.Commands.DeleteProductStock;
using eCommerceLayer.Application.Features.Concrete.ProductStocks.Commands.UpdateProductStock;
using eCommerceLayer.Application.Features.Concrete.ProductStocks.Queries.GetByProductId;

namespace eCommerceLayer.Application.Features.Concrete.ProductStocks.Abstract
{
    public interface IProductStockService: IAddProductStockService, IDeleteProductStockService,
        IUpdateProductStockService, IGetByProductIdQuery
    {
    }
}