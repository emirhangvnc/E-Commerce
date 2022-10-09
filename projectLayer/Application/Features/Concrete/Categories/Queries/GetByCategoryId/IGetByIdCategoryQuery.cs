using eCommerceLayer.Application.Features.Base.Abstract;
using eCommerceLayer.Application.Features.Concrete.Categories.DTOs;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.Categories.Queries.GetByCategoryId
{
    public interface IGetByIdCategoryQuery : IGetByIDService<Category, CategoryGetByIdDto>
    {
    }
}