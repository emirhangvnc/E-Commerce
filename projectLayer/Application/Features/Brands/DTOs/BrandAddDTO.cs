using Core.Persistence.Repositories;

namespace projectLayer.Application.Features.Brands.DTOs
{
    public class BrandAddDTO : IDTO
    {
        public string BrandName { get; set; }
        public BrandAddDTO(string brandName) :base()
        {
            BrandName = brandName;
        }
    }
}