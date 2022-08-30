﻿using coreLayer.Permanency.Paging;
using coreLayer.Permanency.Repositories;

namespace projectLayer.Application.Features.ProductStocks.DTOs
{
    public class ProductStockDeleteDTO : DeleteDTO, IDTO
    {
        public ProductStockDeleteDTO(int id)
        {
            Id = id;
        }
    }
}