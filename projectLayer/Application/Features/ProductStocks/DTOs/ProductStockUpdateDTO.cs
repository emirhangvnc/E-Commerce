﻿using Core.Persistence.Paging;
using Core.Persistence.Repositories;

namespace eCommerceLayer.Application.Features.ProductStocks.DTOs
{
    public class ProductStockUpdateDTO : IDTO
    {
        public int ProductId { get; set; }
        public int UnitStock { get; set; }
    }
}