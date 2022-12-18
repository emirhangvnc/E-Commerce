using eCommerceLayer.Application.Features.Concrete.Features.DTOs;
using FluentValidation;

namespace eCommerceLayer.Application.Features.Concrete.Features.Commands.AddFeature
{
    public class FeatureAddValidator : AbstractValidator<FeatureAddDTO>
    {
        public FeatureAddValidator()
        {
            RuleFor(f => f.FeatureName).NotEmpty();
            RuleFor(f => f.FeatureName).MinimumLength(2);
            RuleFor(f => f.FeatureName).MaximumLength(30);
        }
    }
}