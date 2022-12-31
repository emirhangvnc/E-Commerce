using Core.Utilities.Results;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.ProductFeatures.Rules
{
    public interface IProductFeatureBusinessRules
    {
        Task<IDataResult<ProductFeature>> IsIDExists(int id);
    }
}