using eCommerceLayer.Application.Features.Categories.DTOs;
using eCommerceLayer.Application.Services.Abstract.Base;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Services.Abstract
{
    public interface ICategoryService : IBaseService<Category,
        CategoryAddDTO, CategoryDeleteDTO, CategoryUpdateDTO>
    {
    }
}