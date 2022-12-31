using Core.Utilities.Results;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.Products.Rules
{
    public interface IProductBusinessRules
    {
        Task<IDataResult<Product>> IsIDExists(int id);
    }
}