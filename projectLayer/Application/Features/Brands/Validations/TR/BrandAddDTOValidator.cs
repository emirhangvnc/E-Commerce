using FluentValidation;
using eCommerceLayer.Application.Features.Base.Constants.Languages.TR.Base;
using eCommerceLayer.Application.Features.Base.Constants.Languages.TR.General;
using eCommerceLayer.Application.Features.Brands.Constants.Languages.TR;
using eCommerceLayer.Application.Features.Brands.DTOs;

namespace eCommerceLayer.Application.Features.Brands.Validations.TR
{
    public class BrandAddDTOValidator : AbstractValidator<BrandAddDTO>
    {
        public BrandAddDTOValidator()
        {
            RuleFor(b => b.BrandName).NotEmpty().WithMessage($"{BrandMessagesTR.Brand} {BaseConstantsTR.Name} {BaseConstantsTR.NotNull}");
            RuleFor(b => b.BrandName).MaximumLength(20).WithMessage($"{BrandMessagesTR.Brand} {BaseConstantsTR.Name} {GeneralConstantsTR.Max30Character}");
        }
    }
}
