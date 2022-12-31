using eCommerceLayer.Application.Features.Concrete.ProductFeatures.DTOs;
using FluentValidation;

namespace eCommerceLayer.Application.Features.Concrete.ProductFeatures.Commands.UpdateProductFeature
{
    public class ProductFeatureUpdateValidator : AbstractValidator<ProductFeatureUpdateDTO>
    {
        public ProductFeatureUpdateValidator()
        {
            RuleFor(f => f.Id).NotEmpty();
            RuleFor(f => f.ProductId).NotEmpty();
            RuleFor(f => f.FeatureValueId).NotEmpty();
        }
    }
}