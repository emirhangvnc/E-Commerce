using eCommerceLayer.Application.Features.Concrete.FeatureValues.DTOs;
using eCommerceLayer.Application.Features.Concrete.VariantValues.DTOs;
using FluentValidation;

namespace eCommerceLayer.Application.Features.Concrete.VariantValues.Commands.UpdateVariantValue
{
    public class VariantValueUpdateValidator : AbstractValidator<VariantValueUpdateDTO>
    {
        public VariantValueUpdateValidator()
        {
            RuleFor(f => f.Id).NotEmpty();
            RuleFor(f => f.VariantId).NotEmpty();
            RuleFor(f => f.Value).NotEmpty();
            RuleFor(f => f.Value).MaximumLength(40);
        }
    }
}