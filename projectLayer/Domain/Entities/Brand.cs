using Core.Persistence.Repositories;
using eCommerceLayer.Domain.Entities.Base;

namespace eCommerceLayer.Domain.Entities
{
    public class Brand: BaseEntity,IEntity
    {
        public string BrandName { get; set; }
        public ICollection<BrandImage> BrandImages { get; set; }
        public ICollection<ProductBrand> ProductBrands { get; set; }
    }
}