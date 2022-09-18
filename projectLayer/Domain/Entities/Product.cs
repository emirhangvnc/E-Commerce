﻿using Core.Persistence.Repositories;
using eCommerceLayer.Domain.Entities.Base;

namespace eCommerceLayer.Domain.Entities
{
    public class Product : BaseEntity, IEntity
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public decimal ListPrice { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ICollection<Favorite> Favorites { get; set; }
        public ICollection<ProductBrand> ProductBrands { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
        public ICollection<ProductFeature> ProductFeatures { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }
        public ICollection<ProductStock> ProductStocks { get; set; }
    }
}