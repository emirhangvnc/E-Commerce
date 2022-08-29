using coreLayer.Permanency.Paging;
using coreLayer.Permanency.Repositories;

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