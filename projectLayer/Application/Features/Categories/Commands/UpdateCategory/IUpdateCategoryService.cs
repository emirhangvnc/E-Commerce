using eCommerceLayer.Application.Features.Categories.DTOs;
using eCommerceLayer.Application.Services.Abstract.Base;

namespace eCommerceLayer.Application.Features.Categories.Commands.UpdateCategory
{
    public interface IUpdateCategoryService : IUpdateService<CategoryUpdateDTO>
    {
    }
}