﻿using eCommerceLayer.Application.Features.Base.Abstract;
using eCommerceLayer.Application.Features.Concrete.ProductStocks.DTOs;

namespace eCommerceLayer.Application.Features.Concrete.ProductStocks.Commands.UpdateProductStock
{
    public interface IUpdateProductStockService : IUpdateService<ProductStockUpdateDTO>
    {
    }
}