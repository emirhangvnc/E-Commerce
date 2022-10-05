using FluentValidation;
using eCommerceLayer.Application.Features.Base.Constants.Languages.TR.Base;
using eCommerceLayer.Application.Features.Concrete.Brands.Constants.Languages.TR;
using eCommerceLayer.Application.Features.Concrete.Brands.DTOs;

namespace eCommerceLayer.Application.Features.Concrete.Brands.Commands.DeleteBrand
{
    public class DeleteBrandDTOValidator : AbstractValidator<BrandDeleteDTO>
    {
        public DeleteBrandDTOValidator()
        {
            RuleFor(b => b.Id).NotEmpty().WithMessage($"{BrandMessagesTR.Brand} {BaseConstantsTR.ID} {BaseConstantsTR.NotNull}");
        }
    }
}
