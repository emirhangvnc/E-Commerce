using FluentValidation;
using projectLayer.Application.Features.Base.Constants.Languages.TR.Base;
using projectLayer.Application.Features.Brands.Constants.Languages.TR;
using projectLayer.Application.Features.Brands.DTOs;

namespace projectLayer.Application.Features.Brands.Validations.TR
{
    public class BrandDeleteDTOValidator : AbstractValidator<BrandDeleteDTO>
    {
        public BrandDeleteDTOValidator()
        {
            RuleFor(b => b.Id).NotEmpty().WithMessage($"{BrandMessagesTR.Brand} {BaseConstantsTR.ID} {BaseConstantsTR.NotNull}");
        }
    }
}
