using coreLayer.Permanency.Repositories;

namespace projectLayer.Domain.Entities
{
    public class Brand:Entity
    {
        public string BrandName { get; set; }
        public Brand(string brandName)
        {
            BrandName = brandName;
        }

        public Brand(int id, string brandName) : this(brandName)
        {
            Id = id;
        }
    }
}