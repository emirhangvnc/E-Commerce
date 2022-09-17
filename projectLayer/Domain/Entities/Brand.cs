using Core.Persistence.Repositories;
using eCommerceLayer.Domain.Entities.Base;

namespace eCommerceLayer.Domain.Entities
{
    public class Brand: BaseEntity,IEntity
    {
        public string BrandName { get; set; }
        public Brand(int id, string brandName) : base(id)
        {
            BrandName = brandName;
        }
    }
}