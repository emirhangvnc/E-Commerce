using eCommerceLayer.Application.Features.Base.Abstract.Queries;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.Brands.Queries.GetAllBrand
{
    public interface IGetAllBrandQuery: IGetAllService<Brand>
    {
    }
}