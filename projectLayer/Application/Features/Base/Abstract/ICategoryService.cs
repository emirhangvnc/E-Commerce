using eCommerceLayer.Application.Features.Categories.Commands.AddCategory;
using eCommerceLayer.Application.Features.Categories.Commands.DeleteCategory;
using eCommerceLayer.Application.Features.Categories.Commands.UpdateCategory;
using eCommerceLayer.Application.Features.Categories.Queries.GetByIdCategory;
using eCommerceLayer.Application.Features.Categories.Queries.GetListBrand;

namespace eCommerceLayer.Application.Services.Abstract
{
    public interface ICategoryService: IAddCategoryService, IDeleteCategoryService,
        IUpdateCategoryService, IGetByIdBrandQuery, IGetAllCategoryQuery
    {
    }
}