using Core.Security.Results;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Brands.Rules
{
    public interface IBrandBusinessRules
    {
        Task<IDataResult<Brand>> BrandNameExists(string name);
        Task<IDataResult<Brand>> IsBrandIDExists(int id);
        void BrandShouldExistWhenRequested(Brand brand);
    }
}