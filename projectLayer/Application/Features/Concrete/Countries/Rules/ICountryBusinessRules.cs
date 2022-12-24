using Core.Utilities.Results;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.Countries.Rules
{
    public interface ICountryBusinessRules
    {
        Task<IDataResult<Country>> IsIDExists(int id);
    }
}