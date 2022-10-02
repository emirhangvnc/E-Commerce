using Core.Security.Results;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Categories.Rules
{
    public interface ICategoryBusinessRules
    {
        Task<IDataResult<Category>> CategoryNameExists(string name);
        Task<IDataResult<Category>> IsCategoryIDExists(int id);
        void CategoryShouldExistWhenRequested(Category category);
    }
}