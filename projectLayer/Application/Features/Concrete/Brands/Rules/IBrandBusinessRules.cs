using eCommerceLayer.Application.Features.Base.Rules;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.Brands.Rules
{
    public interface IBrandBusinessRules: IIdNumberExistsService<Brand>, INameExistsService<Brand>
    {
        void BrandShouldExistWhenRequested(Brand brand);
    }
}