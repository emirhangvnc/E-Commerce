using Core.Persistence.Paging;
using Core.Persistence.Repositories;

namespace projectLayer.Application.Features.Categories.DTOs
{
    public class CategoryDeleteDTO : DeleteDTO, IDTO
    {
        public CategoryDeleteDTO(int id)
        {
            Id = id;
        }
    }
}