using Core.Utilities.Results;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.FeatureValues.Rules
{
    public interface IFeatureValueBusinessRules
    {
        Task<IDataResult<FeatureValue>> IsIDExists(int id);
        Task<IResult> FeatureValueNameExists(string name);
    }
}