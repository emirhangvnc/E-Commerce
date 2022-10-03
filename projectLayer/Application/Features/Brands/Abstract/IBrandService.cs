using eCommerceLayer.Application.Features.Brands.Commands.AddBrand;
using eCommerceLayer.Application.Features.Brands.Commands.DeleteBrand;
using eCommerceLayer.Application.Features.Brands.Commands.UpdateBrand;

namespace eCommerceLayer.Application.Features.Brands.Abstract
{
    public interface IBrandService : IAddBrandService, IDeleteBrandService,
        IUpdateBrandService
    {
    }
}