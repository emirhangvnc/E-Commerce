using FluentValidation;
using projectLayer.Application.Features.Base.Constants.Languages.TR.Base;
using projectLayer.Application.Features.Products.Constants.Languages.TR;
using projectLayer.Application.Features.Products.DTOs;

namespace projectLayer.Application.Features.Products.Validations.TR
{
    public class ProductDeleteDTOValidator : AbstractValidator<ProductDeleteDTO>
    {
        public ProductDeleteDTOValidator()
        {
            RuleFor(c => c.Id).NotEmpty().WithMessage($"{ProductMessagesTR.Product} {BaseConstantsTR.ID} {BaseConstantsTR.NotNull}");
        }
    }
}
