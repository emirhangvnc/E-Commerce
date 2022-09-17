using FluentValidation;
using eCommerceLayer.Application.Features.Base.Constants.Languages.TR.Base;
using eCommerceLayer.Application.Features.Products.Constants.Languages.TR;
using eCommerceLayer.Application.Features.Products.DTOs;

namespace eCommerceLayer.Application.Features.Products.Validations.TR
{
    public class ProductDeleteDTOValidator : AbstractValidator<ProductDeleteDTO>
    {
        public ProductDeleteDTOValidator()
        {
            RuleFor(c => c.Id).NotEmpty().WithMessage($"{ProductMessagesTR.Product} {BaseConstantsTR.ID} {BaseConstantsTR.NotNull}");
        }
    }
}
