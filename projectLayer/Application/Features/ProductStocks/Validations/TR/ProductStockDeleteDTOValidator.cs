using FluentValidation;
using projectLayer.Application.Features.Base.Constants.Languages.TR.Base;
using projectLayer.Application.Features.ProductStocks.Constants.Languages.TR;
using projectLayer.Application.Features.ProductStocks.DTOs;

namespace projectLayer.Application.Features.ProductStocks.Validations.TR
{
    public class ProductStockDeleteDTOValidator : AbstractValidator<ProductStockDeleteDTO>
    {
        public ProductStockDeleteDTOValidator()
        {
            RuleFor(c => c.ProductId).NotEmpty().WithMessage($"{ProductStockMessagesTR.ProductStock} {BaseConstantsTR.ID} {BaseConstantsTR.NotNull}");
        }
    }
}