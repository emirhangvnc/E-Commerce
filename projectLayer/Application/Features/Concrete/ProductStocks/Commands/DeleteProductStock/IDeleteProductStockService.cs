﻿using eCommerceLayer.Application.Features.Base.Abstract.Commands;
using eCommerceLayer.Application.Features.Concrete.ProductStocks.DTOs;

namespace eCommerceLayer.Application.Features.Concrete.ProductStocks.Commands.DeleteProductStock
{
    public interface IDeleteProductStockService : IDeleteService<ProductStockDeleteDTO>
    {
    }
}