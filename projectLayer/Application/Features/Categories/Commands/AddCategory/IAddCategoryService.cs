using eCommerceLayer.Application.Features.Categories.DTOs;
using eCommerceLayer.Application.Services.Abstract.Base;

namespace eCommerceLayer.Application.Features.Categories.Commands.AddCategory
{
    public interface IAddCategoryService : IAddService<CategoryAddDTO>
    {
    }
}