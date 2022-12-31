using Core.Utilities.Results;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.ProductVariants.Rules
{
    public interface IProductVariantBusinessRules
    {
        Task<IDataResult<ProductVariant>> IsIDExists(int id);
    }
}