using Core.Persistence.Paging;
using Core.Persistence.Repositories;

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