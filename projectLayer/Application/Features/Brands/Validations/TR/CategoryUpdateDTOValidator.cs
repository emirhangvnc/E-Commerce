using FluentValidation;
using projectLayer.Application.Features.Base.Constants.Languages.TR.Base;
using projectLayer.Application.Features.Base.Constants.Languages.TR.General;
using projectLayer.Application.Features.Brands.Constants.Languages.TR;
using projectLayer.Application.Features.Brands.DTOs;

namespace projectLayer.Application.Features.Categories.Validations.TR
{
    public class BrandUpdateDTOValidator : AbstractValidator<BrandUpdateDTO>
    {
        public BrandUpdateDTOValidator()
        {
            RuleFor(c => c.Id).NotEmpty().WithMessage($"{BrandMessagesTR.Brand} {BaseConstantsTR.ID} {BaseConstantsTR.NotNull}");
            RuleFor(c => c.BrandName).NotEmpty().WithMessage($"{BrandMessagesTR.Brand} {BaseConstantsTR.Name} {BaseConstantsTR.NotNull}");
            RuleFor(c => c.BrandName).MaximumLength(20).WithMessage($"{BrandMessagesTR.Brand} {BaseConstantsTR.Name} {GeneralConstantsTR.Max50Character}");
        }
    }
}
