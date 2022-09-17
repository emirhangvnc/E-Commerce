using Core.Persistence.Repositories;
using eCommerceLayer.Domain.Entities.Base;

namespace eCommerceLayer.Domain.Entities
{
    public class Product : BaseEntity, IEntity
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

        public Product(int id, int categoryId, string productName, decimal price, decimal listPrice, DateTime createdDate,DateTime updatedDate):base(id)
        {
            CategoryId = categoryId;
            ProductName = productName;
            Price = price;
            ListPrice = listPrice;
            CreatedDate= createdDate;
            UpdatedDate = updatedDate;
        }
    }
}