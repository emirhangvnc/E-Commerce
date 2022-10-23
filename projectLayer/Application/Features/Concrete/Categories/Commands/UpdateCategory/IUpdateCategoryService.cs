using eCommerceLayer.Application.Features.Base.Abstract.Commands;
using eCommerceLayer.Application.Features.Concrete.Categories.DTOs;

namespace eCommerceLayer.Application.Features.Concrete.Categories.Commands.UpdateCategory
{
    public interface IUpdateCategoryService : IUpdateService<CategoryUpdateDTO>
    {
    }
}