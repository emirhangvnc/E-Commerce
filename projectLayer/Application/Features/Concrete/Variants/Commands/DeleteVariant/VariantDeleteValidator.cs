using eCommerceLayer.Application.Features.Concrete.Variants.DTOs;
using FluentValidation;

namespace eCommerceLayer.Application.Features.Concrete.Variants.Commands.DeleteVariant
{
    public class VariantDeleteValidator : AbstractValidator<VariantDeleteDTO>
    {
        public VariantDeleteValidator()
        {
            RuleFor(b => b.Id).NotEmpty();
        }
    }
}