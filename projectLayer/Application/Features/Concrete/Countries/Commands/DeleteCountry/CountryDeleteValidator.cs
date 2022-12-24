using eCommerceLayer.Application.Features.Concrete.Countries.DTOs;
using FluentValidation;

namespace eCommerceLayer.Application.Features.Concrete.Countries.Commands.DeleteCountry
{
    public class CountryDeleteValidator : AbstractValidator<CountryDeleteDTO>
    {
        public CountryDeleteValidator()
        {
            RuleFor(f => f.Id).NotEmpty();
        }
    }
}