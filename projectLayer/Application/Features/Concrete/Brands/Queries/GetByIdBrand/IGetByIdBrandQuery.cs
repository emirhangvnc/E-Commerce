using eCommerceLayer.Application.Features.Base.Abstract.Queries;
using eCommerceLayer.Application.Features.Concrete.Brands.DTOs;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.Brands.Queries.GetByIdBrand
{
    public interface IGetByIdBrandQuery : IGetByIDService<Brand, BrandGetByIdDto>
    {
    }
}
