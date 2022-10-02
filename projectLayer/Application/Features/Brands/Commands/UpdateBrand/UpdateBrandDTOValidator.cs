using FluentValidation;
using eCommerceLayer.Application.Features.Base.Constants.Languages.TR.Base;
using eCommerceLayer.Application.Features.Base.Constants.Languages.TR.General;
using eCommerceLayer.Application.Features.Brands.Constants.Languages.TR;
using eCommerceLayer.Application.Features.Brands.DTOs;

namespace eCommerceLayer.Application.Features.Brands.Commands.UpdateBrand
{
    public class UpdateBrandDTOValidator : AbstractValidator<BrandUpdateDTO>
    {
        public UpdateBrandDTOValidator()
        {
            RuleFor(c => c.Id).NotEmpty().WithMessage($"{BrandMessagesTR.Brand} {BaseConstantsTR.ID} {BaseConstantsTR.NotNull}");
            RuleFor(c => c.BrandName).NotEmpty().WithMessage($"{BrandMessagesTR.Brand} {BaseConstantsTR.Name} {BaseConstantsTR.NotNull}");
            RuleFor(c => c.BrandName).MaximumLength(20).WithMessage($"{BrandMessagesTR.Brand} {BaseConstantsTR.Name} {GeneralConstantsTR.Max30Character}");
        }
    }
}