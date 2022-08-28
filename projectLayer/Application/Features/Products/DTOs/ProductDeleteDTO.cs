using coreLayer.Persistence.Paging;
using coreLayer.Persistence.Repositories;

namespace projectLayer.Application.Features.Products.DTOs
{
    public class ProductDeleteDTO : DeleteDTO, IDTO
    {
        public ProductDeleteDTO(int id)
        {
            Id = id;
        }
    }
}