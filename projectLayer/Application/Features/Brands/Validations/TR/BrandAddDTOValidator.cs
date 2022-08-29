using FluentValidation;
using projectLayer.Application.Features.Base.Constants.Languages.TR.Base;
using projectLayer.Application.Features.Base.Constants.Languages.TR.General;
using projectLayer.Application.Features.Brands.Constants.Languages.TR;
using projectLayer.Application.Features.Brands.DTOs;

namespace projectLayer.Application.Features.Brands.Validations.TR
{
    public class BrandAddDTOValidator : AbstractValidator<BrandAddDTO>
    {
        public BrandAddDTOValidator()
        {
            RuleFor(b => b.BrandName).NotEmpty().WithMessage($"{BrandMessagesTR.Brand} {BaseConstantsTR.Name} {BaseConstantsTR.NotNull}");
            RuleFor(b => b.BrandName).MaximumLength(20).WithMessage($"{BrandMessagesTR.Brand} {BaseConstantsTR.Name} {GeneralConstantsTR.Max50Character}");
        }
    }
}
