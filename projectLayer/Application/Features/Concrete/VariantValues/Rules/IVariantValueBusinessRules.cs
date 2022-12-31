using Core.Utilities.Results;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.VariantValues.Rules
{
    public interface IVariantValueBusinessRules
    {
        Task<IDataResult<VariantValue>> IsIDExists(int id);
        Task<IResult> VariantValueNameExists(string name);
    }
}