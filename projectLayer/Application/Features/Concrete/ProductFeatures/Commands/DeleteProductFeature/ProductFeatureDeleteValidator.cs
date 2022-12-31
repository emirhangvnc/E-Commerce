using eCommerceLayer.Application.Features.Concrete.ProductFeatures.DTOs;
using FluentValidation;

namespace eCommerceLayer.Application.Features.Concrete.ProductFeatures.Commands.DeleteProductFeature
{
    public class ProductFeatureDeleteValidator : AbstractValidator<ProductFeatureDeleteDTO>
    {
        public ProductFeatureDeleteValidator()
        {
            RuleFor(f => f.Id).NotEmpty();
        }
    }
}