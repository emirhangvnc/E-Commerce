using eCommerceLayer.Application.Features.Concrete.Cities.DTOs;
using FluentValidation;

namespace eCommerceLayer.Application.Features.Concrete.Cities.Commands.DeleteCity
{
    public class CityDeleteValidator : AbstractValidator<CityDeleteDTO>
    {
        public CityDeleteValidator()
        {
            RuleFor(f => f.Id).NotEmpty();
        }
    }
}