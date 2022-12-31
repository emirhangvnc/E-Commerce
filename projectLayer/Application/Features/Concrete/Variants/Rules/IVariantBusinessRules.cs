using Core.Utilities.Results;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.Variants.Rules
{
    public interface IVariantBusinessRules
    {
        Task<IDataResult<Variant>> IsIDExists(int id);
        Task<IResult> VariantNameExists(string name);
    }
}