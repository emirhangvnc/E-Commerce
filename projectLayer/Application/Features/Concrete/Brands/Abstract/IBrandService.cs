using eCommerceLayer.Application.Features.Concrete.Brands.Commands.AddBrand;
using eCommerceLayer.Application.Features.Concrete.Brands.Commands.DeleteBrand;
using eCommerceLayer.Application.Features.Concrete.Brands.Commands.UpdateBrand;

namespace eCommerceLayer.Application.Features.Concrete.Brands.Abstract
{
    public interface IBrandService : IAddBrandService, IDeleteBrandService,
        IUpdateBrandService
    {
    }
}