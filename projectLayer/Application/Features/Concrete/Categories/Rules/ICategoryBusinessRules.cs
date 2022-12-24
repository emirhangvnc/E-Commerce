using Core.Utilities.Results;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.Categories.Rules
{
    public interface ICategoryBusinessRules
    {
        Task<IDataResult<Category>> IsIDExists(int id);
        Task<IResult> CategoryNameExists(string name);
    }
}