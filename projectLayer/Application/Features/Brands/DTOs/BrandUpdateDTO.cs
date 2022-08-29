using coreLayer.Permanency.Paging;
using coreLayer.Permanency.Repositories;

namespace projectLayer.Application.Features.Brands.DTOs
{
    public class BrandUpdateDTO : UpdateDTO, IDTO
    {
        public string BrandName { get; set; }
        public BrandUpdateDTO(int id, string brandName)
        {
            Id = id;
            BrandName = brandName;
        }
    }
}