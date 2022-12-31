using Core.Utilities.Results;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.ProductBrands.Rules
{
    public interface IProductBrandBusinessRules
    {
        Task<IDataResult<ProductBrand>> IsIDExists(int id);
    }
}