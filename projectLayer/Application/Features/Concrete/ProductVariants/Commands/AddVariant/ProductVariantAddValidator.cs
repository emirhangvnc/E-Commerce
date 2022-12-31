using eCommerceLayer.Application.Features.Concrete.ProductVariants.DTOs;
using FluentValidation;

namespace eCommerceLayer.Application.Features.Concrete.ProductVariants.Commands.AddVariant
{
    public class ProductVariantAddValidator : AbstractValidator<ProductVariantAddDTO>
    {
        public ProductVariantAddValidator()
        {
            RuleFor(f => f.ProductId).NotEmpty();
            RuleFor(f => f.VariantValueId).NotEmpty();

            RuleFor(f => f.VariantSku).MaximumLength(80);

            RuleFor(f => f.VariantGtin).MaximumLength(80);
        }
    }
}