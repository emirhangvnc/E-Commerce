using eCommerceLayer.Application.Features.Concrete.ProductVariants.DTOs;
using FluentValidation;

namespace eCommerceLayer.Application.Features.Concrete.ProductVariants.Commands.UpdateVariant
{
    public class ProductVariantUpdateValidator : AbstractValidator<ProductVariantUpdateDTO>
    {
        public ProductVariantUpdateValidator()
        {
            RuleFor(f => f.Id).NotEmpty();
            RuleFor(f => f.ProductId).NotEmpty();
            RuleFor(f => f.VariantValueId).NotEmpty();

            RuleFor(f => f.VariantSku).MaximumLength(80);

            RuleFor(f => f.VariantGtin).MaximumLength(80);
        }
    }
}