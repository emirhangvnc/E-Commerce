using eCommerceLayer.Application.Features.Concrete.Features.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceLayer.Application.Features.Concrete.Features.Commands.DeleteFeature
{
    public class FeatureDeleteValidator : AbstractValidator<FeatureDeleteDTO>
    {
        public FeatureDeleteValidator()
        {
            RuleFor(f => f.Id).NotEmpty();
        }
    }
}