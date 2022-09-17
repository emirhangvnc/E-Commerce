using eCommerceLayer.Application.Features.Base.DTOs;
using Core.Persistence.Repositories;

namespace eCommerceLayer.Application.Features.Categories.DTOs
{
    public class CategoryDeleteDTO : DeleteDTO, IDTO
    {
        public CategoryDeleteDTO(int id)
        {
            Id = id;
        }
    }
}