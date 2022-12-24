using eCommerceLayer.Application.Features.Concrete.Categories.DTOs;
using FluentValidation;

namespace eCommerceLayer.Application.Features.Concrete.Categories.Commands.UpdateCategory
{
    public class CategoryUpdateValidator : AbstractValidator<CategoryUpdateDTO>
    {
        public CategoryUpdateValidator()
        {
            RuleFor(f => f.Id).NotEmpty();
            RuleFor(f => f.CategoryName).NotEmpty();
            RuleFor(f => f.CategoryName).MaximumLength(30);
        }
    }
}