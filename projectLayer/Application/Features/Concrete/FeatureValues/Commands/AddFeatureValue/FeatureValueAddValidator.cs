using eCommerceLayer.Application.Features.Concrete.FeatureValues.DTOs;
using FluentValidation;

namespace eCommerceLayer.Application.Features.Concrete.FeatureValues.Commands.AddFeatureValue
{
    public class FeatureValueAddValidator : AbstractValidator<FeatureValueAddDTO>
    {
        public FeatureValueAddValidator()
        {
            RuleFor(f => f.FeatureId).NotEmpty();
            RuleFor(f => f.Value).NotEmpty();
            RuleFor(f => f.Value).MaximumLength(40);
        }
    }
}