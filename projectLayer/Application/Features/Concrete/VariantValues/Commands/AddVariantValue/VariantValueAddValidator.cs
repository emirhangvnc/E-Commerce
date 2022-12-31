using eCommerceLayer.Application.Features.Concrete.VariantValues.DTOs;
using FluentValidation;

namespace eCommerceLayer.Application.Features.Concrete.VariantValues.Commands.AddVariantValue
{
    public class VariantValueAddValidator : AbstractValidator<VariantValueAddDTO>
    {
        public VariantValueAddValidator()
        {
            RuleFor(v => v.VariantId).NotEmpty();
            RuleFor(v => v.Value).NotEmpty();
            RuleFor(v => v.Value).MaximumLength(40);
        }
    }
}