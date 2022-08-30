﻿using coreLayer.Permanency.Paging;
using coreLayer.Permanency.Repositories;

namespace projectLayer.Application.Features.Products.DTOs
{
    public class ProductUpdateDTO : UpdateDTO, IDTO
    {
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public decimal ListPrice { get; set; }

        public ProductUpdateDTO(int id,int categoryId, string productName, decimal price, decimal listPrice) : base()
        {
            Id = id;
            CategoryId = categoryId;
            ProductName = productName;
            Price = price;
            ListPrice = listPrice;
        }
    }
}