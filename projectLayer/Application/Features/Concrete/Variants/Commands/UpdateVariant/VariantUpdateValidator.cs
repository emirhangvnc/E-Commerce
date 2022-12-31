using eCommerceLayer.Application.Features.Concrete.Brands.DTOs;
using eCommerceLayer.Application.Features.Concrete.Variants.DTOs;
using FluentValidation;

namespace eCommerceLayer.Application.Features.Concrete.Variants.Commands.UpdateVariant
{
    public class VariantUpdateValidator : AbstractValidator<VariantUpdateDTO>
    {
        public VariantUpdateValidator()
        {
            RuleFor(b => b.Id).NotEmpty();
            RuleFor(b => b.VariantName).NotEmpty();
            RuleFor(b => b.VariantName).MaximumLength(30);
        }
    }
}