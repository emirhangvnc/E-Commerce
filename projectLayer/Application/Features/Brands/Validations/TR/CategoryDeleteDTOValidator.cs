using FluentValidation;
using eCommerceLayer.Application.Features.Base.Constants.Languages.TR.Base;
using eCommerceLayer.Application.Features.Brands.Constants.Languages.TR;
using eCommerceLayer.Application.Features.Brands.DTOs;

namespace eCommerceLayer.Application.Features.Brands.Validations.TR
{
    public class BrandDeleteDTOValidator : AbstractValidator<BrandDeleteDTO>
    {
        public BrandDeleteDTOValidator()
        {
            RuleFor(b => b.Id).NotEmpty().WithMessage($"{BrandMessagesTR.Brand} {BaseConstantsTR.ID} {BaseConstantsTR.NotNull}");
        }
    }
}
