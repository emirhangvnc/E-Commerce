using Core.Security.Results;
using eCommerceLayer.Application.Features.Base.Rules;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.Categories.Rules
{
    public interface ICategoryBusinessRules : IIdNumberExistsService<Category>, INameExistsService<Category>
    {
        void CategoryShouldExistWhenRequested(Category category);
    }
}