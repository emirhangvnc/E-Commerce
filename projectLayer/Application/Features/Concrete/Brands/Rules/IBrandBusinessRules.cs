using Core.Utilities.Results;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.Brands.Rules
{
    public interface IBrandBusinessRules
    {
        Task<IDataResult<Brand>> IsIDExists(int id);
        Task<IResult> BrandNameExists(string name);
    }
}