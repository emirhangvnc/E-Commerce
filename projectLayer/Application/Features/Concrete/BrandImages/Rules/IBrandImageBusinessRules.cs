using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Base.Rules;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.BrandImages.Rules
{
    public interface IBrandImageBusinessRules : IIdNumberExistsService<BrandImage>
    {
        Task<IDataResult<Brand>> IsBrandIDExists(int id);
    }
}