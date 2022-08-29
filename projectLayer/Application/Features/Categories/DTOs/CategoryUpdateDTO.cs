using coreLayer.Permanency.Paging;
using coreLayer.Permanency.Repositories;

namespace projectLayer.Application.Features.Categories.DTOs
{
    public class CategoryUpdateDTO : UpdateDTO, IDTO
    {
        public string CategoryName { get; set; }
        public CategoryUpdateDTO(int id, string categoryName)
        {
            Id = id;
            CategoryName=categoryName;
        }
    }
}