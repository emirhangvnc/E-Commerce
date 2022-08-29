using coreLayer.Permanency.Paging;
using coreLayer.Permanency.Repositories;

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