using eCommerceLayer.Application.Features.Base.Constants.Languages.TR.Base;
using eCommerceLayer.Application.Features.Concrete.BrandImages.Constants.Languages.TR;
using eCommerceLayer.Application.Features.Concrete.BrandImages.DTOs;
using eCommerceLayer.Application.Features.Concrete.Brands.Constants.Languages.TR;
using FluentValidation;

namespace eCommerceLayer.Application.Features.Concrete.BrandImages.Commands.UpdateBrandImage
{
    public class UpdateBrandImageDTOValidator : AbstractValidator<BrandImageUpdateDTO>
    {
        public UpdateBrandImageDTOValidator()
        {
            RuleFor(b => b.ID).NotEmpty().WithMessage($"{BrandImageMessagesTR.BrandImage} {BaseConstantsTR.NotNull}");
            RuleFor(b => b.BrandId).NotEmpty().WithMessage($"{BrandMessagesTR.BrandNotFound}");
            RuleFor(b => b.File).NotEmpty().WithMessage($"{BaseConstantsTR.File} {BaseConstantsTR.NotNull}");
        }
    }
}