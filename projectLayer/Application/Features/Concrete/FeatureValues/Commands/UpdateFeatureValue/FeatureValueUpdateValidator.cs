using eCommerceLayer.Application.Features.Concrete.FeatureValues.DTOs;
using FluentValidation;

namespace eCommerceLayer.Application.Features.Concrete.FeatureValues.Commands.UpdateFeatureValue
{
    public class FeatureValueUpdateValidator : AbstractValidator<FeatureValueUpdateDTO>
    {
        public FeatureValueUpdateValidator()
        {
            RuleFor(f => f.Id).NotEmpty();
            RuleFor(f => f.FeatureId).NotEmpty();
            RuleFor(f => f.Value).NotEmpty();
            RuleFor(f => f.Value).MaximumLength(40);
        }
    }
}