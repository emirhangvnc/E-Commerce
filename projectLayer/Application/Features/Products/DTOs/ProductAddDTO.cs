using coreLayer.Persistence.Repositories;

namespace projectLayer.Application.Features.Products.DTOs
{
    public class ProductAddDTO : IDTO
    {
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public decimal ListPrice { get; set; }

        public ProductAddDTO(int categoryId, string productName, decimal price, decimal listPrice) :base()
        {
            CategoryId = categoryId;
            ProductName = productName;
            Price = price;
            ListPrice = listPrice;
        }
    }
}