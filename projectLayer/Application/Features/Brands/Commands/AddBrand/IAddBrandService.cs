using eCommerceLayer.Application.Features.Base.Abstract;
using eCommerceLayer.Application.Features.Brands.DTOs;

namespace eCommerceLayer.Application.Features.Brands.Commands.AddBrand
{
    public interface IAddBrandService: IAddService<BrandAddDTO>
    {
    }
}