using FluentValidation;
using eCommerceLayer.Application.Features.Base.Constants.Languages.TR.Base;
using eCommerceLayer.Application.Features.Brands.Constants.Languages.TR;
using eCommerceLayer.Application.Features.Brands.DTOs;

namespace eCommerceLayer.Application.Features.Brands.Commands.DeleteBrand
{
    public class DeleteBrandDTOValidator : AbstractValidator<BrandDeleteDTO>
    {
        public DeleteBrandDTOValidator()
        {
            RuleFor(b => b.Id).NotEmpty().WithMessage($"{BrandMessagesTR.Brand} {BaseConstantsTR.ID} {BaseConstantsTR.NotNull}");
        }
    }
}
