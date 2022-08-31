using Core.Persistence.Paging;
using Core.Persistence.Repositories;

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