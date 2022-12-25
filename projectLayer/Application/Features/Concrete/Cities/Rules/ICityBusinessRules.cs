using Core.Utilities.Results;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.Cities.Rules
{
    public interface ICityBusinessRules
    {
        Task<IDataResult<City>> IsIDExists(int id);
    }
}