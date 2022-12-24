using eCommerceLayer.Application.Features.Concrete.Categories.DTOs;
using FluentValidation;

namespace eCommerceLayer.Application.Features.Concrete.Categories.Commands.DeleteCategory
{
    public class CategoryDeleteValidator : AbstractValidator<CategoryDeleteDTO>
    {
        public CategoryDeleteValidator()
        {
            RuleFor(f => f.Id).NotEmpty();
        }
    }
}