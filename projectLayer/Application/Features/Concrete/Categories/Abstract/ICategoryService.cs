using eCommerceLayer.Application.Features.Concrete.Categories.Commands.AddCategory;
using eCommerceLayer.Application.Features.Concrete.Categories.Commands.DeleteCategory;
using eCommerceLayer.Application.Features.Concrete.Categories.Commands.UpdateCategory;
using eCommerceLayer.Application.Features.Concrete.Categories.Queries.GetByCategoryId;
using eCommerceLayer.Application.Features.Concrete.Categories.Queries.GetListCategory;

namespace eCommerceLayer.Application.Features.Concrete.Categories.Abstract
{
    public interface ICategoryService : IAddCategoryService, IDeleteCategoryService,
        IUpdateCategoryService, IGetByIdCategoryQuery, IGetAllCategoryQuery
    {
    }
}