using Core.Persistence.Repositories;

namespace projectLayer.Domain.Entities
{
    public class Brand:Entity
    {
        public string BrandName { get; set; }
        public Brand(int id, string brandName) : base(id)
        {
            BrandName = brandName;
        }
    }
}