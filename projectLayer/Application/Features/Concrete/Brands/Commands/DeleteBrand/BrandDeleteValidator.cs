using eCommerceLayer.Application.Features.Concrete.Brands.DTOs;
using FluentValidation;

namespace eCommerceLayer.Application.Features.Concrete.Brands.Commands.DeleteBrand
{
    public class BrandDeleteValidator : AbstractValidator<BrandDeleteDTO>
    {
        public BrandDeleteValidator()
        {
            RuleFor(b => b.Id).NotEmpty();
        }
    }
}