using eCommerceLayer.Application.Features.Concrete.Categories.DTOs;
using FluentValidation;

namespace eCommerceLayer.Application.Features.Concrete.Categories.Commands.AddCategory
{
    public class CategoryAddValidator : AbstractValidator<CategoryAddDTO>
    {
        public CategoryAddValidator()
        {
            RuleFor(f => f.CategoryName).NotEmpty();
            RuleFor(f => f.CategoryName).MaximumLength(30);
        }
    }
}