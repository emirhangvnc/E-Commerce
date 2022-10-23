using eCommerceLayer.Application.Features.Base.Abstract.Commands;
using eCommerceLayer.Application.Features.Concrete.Brands.DTOs;

namespace eCommerceLayer.Application.Features.Concrete.Brands.Commands.AddBrand
{
    public interface IAddBrandService: IAddService<BrandAddDTO>
    {
    }
}