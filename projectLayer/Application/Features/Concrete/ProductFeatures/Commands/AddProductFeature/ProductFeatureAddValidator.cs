using eCommerceLayer.Application.Features.Concrete.ProductFeatures.DTOs;
using FluentValidation;

namespace eCommerceLayer.Application.Features.Concrete.ProductFeatures.Commands.AddProductFeature
{
    public class ProductFeatureAddValidator : AbstractValidator<ProductFeatureAddDTO>
    {
        public ProductFeatureAddValidator()
        {
            RuleFor(f => f.ProductId).NotEmpty();
            RuleFor(f => f.FeatureValueId).NotEmpty();
        }
    }
}