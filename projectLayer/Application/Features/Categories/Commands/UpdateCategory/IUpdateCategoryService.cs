using eCommerceLayer.Application.Features.Base.Abstract;
using eCommerceLayer.Application.Features.Categories.DTOs;

namespace eCommerceLayer.Application.Features.Categories.Commands.UpdateCategory
{
    public interface IUpdateCategoryService : IUpdateService<CategoryUpdateDTO>
    {
    }
}