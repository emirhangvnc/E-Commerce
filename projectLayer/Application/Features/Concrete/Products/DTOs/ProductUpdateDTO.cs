using eCommerceLayer.Application.Features.Base.DTOs;
using Core.Persistence.Repositories;

namespace eCommerceLayer.Application.Features.Concrete.Products.DTOs
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