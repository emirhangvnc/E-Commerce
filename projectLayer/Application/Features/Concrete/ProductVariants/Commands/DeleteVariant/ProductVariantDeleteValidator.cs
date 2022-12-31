using eCommerceLayer.Application.Features.Concrete.ProductVariants.DTOs;
using FluentValidation;

namespace eCommerceLayer.Application.Features.Concrete.ProductVariants.Commands.DeleteVariant
{
    public class ProductVariantDeleteValidator : AbstractValidator<ProductVariantDeleteDTO>
    {
        public ProductVariantDeleteValidator()
        {
            RuleFor(f => f.Id).NotEmpty();
        }
    }
}
