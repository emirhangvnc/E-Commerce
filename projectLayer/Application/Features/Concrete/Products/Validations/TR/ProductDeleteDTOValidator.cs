using FluentValidation;
using eCommerceLayer.Application.Features.Base.Constants.Languages.TR.Base;
using eCommerceLayer.Application.Features.Concrete.Products.Constants.Languages.TR;
using eCommerceLayer.Application.Features.Concrete.Products.DTOs;

namespace eCommerceLayer.Application.Features.Concrete.Products.Validations.TR
{
    public class ProductDeleteDTOValidator : AbstractValidator<ProductDeleteDTO>
    {
        public ProductDeleteDTOValidator()
        {
            RuleFor(c => c.Id).NotEmpty().WithMessage($"{ProductMessagesTR.Product} {BaseConstantsTR.ID} {BaseConstantsTR.NotNull}");
        }
    }
}
