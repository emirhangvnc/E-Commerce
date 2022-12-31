using Core.Utilities.Results;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.ProductCategories.Rules
{
    public interface IProductCategoryBusinessRules
    {
        Task<IDataResult<ProductCategory>> IsIDExists(int id);
    }
}