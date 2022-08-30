using FluentValidation;
using projectLayer.Application.Features.Base.Constants.Languages.TR.Base;
using projectLayer.Application.Features.Products.Constants.Languages.TR;
using projectLayer.Application.Features.ProductStocks.Constants.Languages.TR;
using projectLayer.Application.Features.ProductStocks.DTOs;

namespace projectLayer.Application.Features.ProductStocks.Validations.TR
{
    public class ProductStockUpdateDTOValidator : AbstractValidator<ProductStockUpdateDTO>
    {
        public ProductStockUpdateDTOValidator()
        {
            RuleFor(c => c.Id).NotEmpty().WithMessage($"{ProductStockMessagesTR.ProductStock} {BaseConstantsTR.ID} {BaseConstantsTR.NotNull}");
            RuleFor(p => p.ProductId).NotEmpty().WithMessage($"{ProductMessagesTR.Product} {BaseConstantsTR.ID} {BaseConstantsTR.NotNull}");
            RuleFor(p => p.UnitStock).NotEmpty().WithMessage($"{ProductStockMessagesTR.ProductStock} Değeri {BaseConstantsTR.NotNull}");
        }
    }
}
