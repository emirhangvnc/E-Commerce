using eCommerceLayer.Application.Features.Concrete.Brands.DTOs;
using eCommerceLayer.Application.Features.Concrete.Countries.DTOs;
using FluentValidation;

namespace eCommerceLayer.Application.Features.Concrete.Countries.Commands.AddCountry
{
    public class CountryAddValidator : AbstractValidator<CountryAddDTO>
    {
        public CountryAddValidator()
        {
            RuleFor(f => f.CountryName).NotEmpty();
            RuleFor(f => f.CountryName).MaximumLength(60);

            RuleFor(f => f.Alpha2Code).MaximumLength(2);
            RuleFor(f => f.Alpha3Code).MaximumLength(3);
        }
    }
}