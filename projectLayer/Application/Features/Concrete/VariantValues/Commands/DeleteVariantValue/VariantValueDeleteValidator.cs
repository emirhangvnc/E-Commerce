using eCommerceLayer.Application.Features.Concrete.VariantValues.DTOs;
using FluentValidation;

namespace eCommerceLayer.Application.Features.Concrete.VariantValues.Commands.DeleteVariantValue
{
    public class VariantValueDeleteValidator : AbstractValidator<VariantValueDeleteDTO>
    {
        public VariantValueDeleteValidator()
        {
            RuleFor(f => f.Id).NotEmpty();
        }
    }
}