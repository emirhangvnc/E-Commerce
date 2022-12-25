using eCommerceLayer.Application.Features.Concrete.Cities.DTOs;
using FluentValidation;

namespace eCommerceLayer.Application.Features.Concrete.Cities.Commands.UpdateCity
{
    public class CityUpdateValidator : AbstractValidator<CityUpdateDTO>
    {
        public CityUpdateValidator()
        {
            RuleFor(f => f.Id).NotEmpty();
            RuleFor(f => f.CityName).NotEmpty();
            RuleFor(f => f.CityName).MaximumLength(60);

            RuleFor(f => f.CountryId).NotEmpty();

            RuleFor(f => f.CityCode).NotEmpty();
            RuleFor(f => f.CityCode).MaximumLength(30);
        }
    }
}