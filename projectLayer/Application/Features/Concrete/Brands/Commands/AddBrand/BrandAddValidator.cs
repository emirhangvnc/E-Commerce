using eCommerceLayer.Application.Features.Concrete.Brands.DTOs;
using FluentValidation;

namespace eCommerceLayer.Application.Features.Concrete.Brands.Commands.AddBrand
{
    public class BrandAddValidator : AbstractValidator<BrandAddDTO>
    {
        public BrandAddValidator()
        {
            RuleFor(f => f.BrandName).NotEmpty();
            RuleFor(f => f.BrandName).MaximumLength(30);
        }
    }
}