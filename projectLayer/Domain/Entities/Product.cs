using coreLayer.Persistence.Repositories;

namespace projectLayer.Domain.Entities
{
    public class Product : Entity
    {
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public decimal ListPrice { get; set; }

        public Product(int categoryId, string productName, decimal price, decimal listPrice)
        {
            CategoryId = categoryId;
            ProductName = productName;
            Price = price;
            ListPrice = listPrice;
        }

        public Product(int id, int categoryId, string productName, decimal price, decimal listPrice) : this(categoryId, productName, price, listPrice)
        {
            Id = id;
        }
    }
}