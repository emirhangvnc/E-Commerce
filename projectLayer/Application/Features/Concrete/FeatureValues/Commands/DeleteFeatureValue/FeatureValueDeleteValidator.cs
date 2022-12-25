using eCommerceLayer.Application.Features.Concrete.FeatureValues.DTOs;
using FluentValidation;

namespace eCommerceLayer.Application.Features.Concrete.FeatureValues.Commands.DeleteFeatureValue
{
    public class FeatureValueDeleteValidator : AbstractValidator<FeatureValueDeleteDTO>
    {
        public FeatureValueDeleteValidator()
        {
            RuleFor(f => f.Id).NotEmpty();
        }
    }
}