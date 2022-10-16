using Core.Persistence.Repositories;
using eCommerceLayer.Domain.Entities.Base;

namespace eCommerceLayer.Domain.Entities
{
    public class Product : BaseEntity, IEntity
    {
        public string ProductId { get; set; }
        public string ModelCode { get; set; }
        public string Sku { get; set; }
        public string Gtin { get; set; }
        public string ProductName { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public decimal Weight { get; set; }
        public int PriceId { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ICollection<Favorite> Favorites { get; set; }
        public ICollection<ProductBrand> ProductBrands { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
        public ICollection<ProductFeature> ProductFeatures { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }
        public ICollection<ProductPrice> ProductPrices { get; set; }
        public ICollection<ProductStock> ProductStocks { get; set; }
        public ICollection<ProductVariant> ProductVariants { get; set; }
    }
}