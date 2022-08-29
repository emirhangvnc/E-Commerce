using coreLayer.Permanency.Paging;
using coreLayer.Permanency.Repositories;

namespace projectLayer.Application.Features.Brands.DTOs
{
    public class BrandDeleteDTO : DeleteDTO, IDTO
    {
        public BrandDeleteDTO(int id)
        {
            Id = id;
        }
    }
}