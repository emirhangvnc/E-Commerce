using eCommerceLayer.Application.Features.Concrete.Brands.DTOs;
using FluentValidation;

namespace eCommerceLayer.Application.Features.Concrete.Brands.Commands.UpdateBrand
{
    public class BrandUpdateValidator : AbstractValidator<BrandUpdateDTO>
    {
        public BrandUpdateValidator()
        {
            RuleFor(b => b.Id).NotEmpty();
            RuleFor(b => b.BrandName).NotEmpty();
            RuleFor(b => b.BrandName).MaximumLength(30);
        }
    }
}