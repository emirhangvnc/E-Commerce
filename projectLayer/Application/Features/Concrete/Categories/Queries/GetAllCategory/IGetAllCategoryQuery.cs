using eCommerceLayer.Application.Features.Base.Abstract.Queries;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.Categories.Queries.GetListCategory
{
    public interface IGetAllCategoryQuery : IGetAllService<Category>
    {
    }
}