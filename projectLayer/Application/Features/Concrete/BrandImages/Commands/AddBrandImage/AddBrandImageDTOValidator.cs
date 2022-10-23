using eCommerceLayer.Application.Features.Concrete.BrandImages.DTOs;
using eCommerceLayer.Application.Features.Concrete.Brands.Constants.Languages.TR;
using FluentValidation;

namespace eCommerceLayer.Application.Features.Concrete.BrandImages.Commands.AddBrandImage
{
    public class AddBrandImageDTOValidator : AbstractValidator<BrandImageUploadDTO>
    {
        public AddBrandImageDTOValidator()
        {
            RuleFor(b => b.BrandId).NotEmpty().WithMessage($"{BrandMessagesTR.BrandNotFound}");
        }
    }
}