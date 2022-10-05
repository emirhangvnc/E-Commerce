using eCommerceLayer.Application.Features.Base.DTOs;
using Core.Persistence.Repositories;

namespace eCommerceLayer.Application.Features.Concrete.Categories.DTOs
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