using eCommerceLayer.Application.Features.Concrete.Brands.Commands.AddBrand;
using eCommerceLayer.Application.Features.Concrete.Brands.Commands.DeleteBrand;
using eCommerceLayer.Application.Features.Concrete.Brands.Commands.UpdateBrand;
using eCommerceLayer.Application.Features.Concrete.Brands.Queries.GetAllBrand;
using eCommerceLayer.Application.Features.Concrete.Brands.Queries.GetByIdBrand;

namespace eCommerceLayer.Application.Features.Concrete.Brands.Abstract
{
    public interface IBrandService : IAddBrandService, IDeleteBrandService,
        IUpdateBrandService, IGetByIdBrandQuery, IGetAllBrandQuery
    {
    }
}