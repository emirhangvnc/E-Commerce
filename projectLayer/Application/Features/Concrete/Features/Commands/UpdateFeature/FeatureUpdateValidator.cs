using eCommerceLayer.Application.Features.Concrete.Features.DTOs;
using FluentValidation;

namespace eCommerceLayer.Application.Features.Concrete.Features.Commands.UpdateFeature
{
    public class FeatureUpdateValidator : AbstractValidator<FeatureUpdateDTO>
    {
        public FeatureUpdateValidator()
        {
            RuleFor(f => f.Id).NotEmpty();
            RuleFor(f => f.FeatureName).NotEmpty();
            RuleFor(f => f.FeatureName).MinimumLength(2);
            RuleFor(f => f.FeatureName).MaximumLength(30);
        }
    }
}