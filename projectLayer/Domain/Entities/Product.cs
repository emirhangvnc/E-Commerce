using coreLayer.Permanency.Repositories;

namespace projectLayer.Domain.Entities
{
    public class Product : Entity
    {
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public decimal ListPrice { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ICollection<ProductBrand> ProductBrands { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
        public ICollection<ProductFeature> ProductFeatures { get; set; }

        public Product(int categoryId, string productName, decimal price, decimal listPrice, DateTime createdDate,DateTime updatedDate)
        {
            CategoryId = categoryId;
            ProductName = productName;
            Price = price;
            ListPrice = listPrice;
            CreatedDate= createdDate;
            UpdatedDate = updatedDate;
        }

        public Product(int id, int categoryId, string productName, decimal price, decimal listPrice, DateTime createdDate, DateTime updatedDate) : this(categoryId, productName, price, listPrice, createdDate, updatedDate)
        {
            Id = id;
        }
    }
}