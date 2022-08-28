using projectLayer.Application.Features.Categories.DTOs;
using projectLayer.Application.Services.Abstract.Base;
using projectLayer.Domain.Entities;

namespace projectLayer.Application.Services.Abstract
{
    public interface ICategoryService : IBaseService<Category,
        CategoryAddDTO, CategoryDeleteDTO, CategoryUpdateDTO>
    {
    }
}