using eCommerceLayer.Application.Features.Concrete.Countries.DTOs;
using FluentValidation;

namespace eCommerceLayer.Application.Features.Concrete.Countries.Commands.UpdateCountry
{
    public class CountryUpdateValidator : AbstractValidator<CountryUpdateDTO>
    {
        public CountryUpdateValidator()
        {
            RuleFor(p => p.Id).NotEmpty();
            RuleFor(p => p.CountryName).NotEmpty();
            RuleFor(p => p.CountryName).MaximumLength(60);
                         
            RuleFor(p => p.Alpha2Code).MaximumLength(2);
            RuleFor(p => p.Alpha3Code).MaximumLength(3);
        }
    }
}