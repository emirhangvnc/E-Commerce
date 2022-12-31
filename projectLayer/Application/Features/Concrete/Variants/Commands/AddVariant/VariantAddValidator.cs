using eCommerceLayer.Application.Features.Concrete.Variants.DTOs;
using FluentValidation;

namespace eCommerceLayer.Application.Features.Concrete.Variants.Commands.AddVariant
{
    public class VariantAddValidator : AbstractValidator<VariantAddDTO>
    {
        public VariantAddValidator()
        {
            RuleFor(v => v.VariantName).NotEmpty();
            RuleFor(v => v.VariantName).MaximumLength(30);
        }
    }
}