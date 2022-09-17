using FluentValidation;
using eCommerceLayer.Application.Features.Base.Constants.Languages.TR.Base;
using eCommerceLayer.Application.Features.ProductStocks.Constants.Languages.TR;
using eCommerceLayer.Application.Features.ProductStocks.DTOs;

namespace eCommerceLayer.Application.Features.ProductStocks.Validations.TR
{
    public class ProductStockDeleteDTOValidator : AbstractValidator<ProductStockDeleteDTO>
    {
        public ProductStockDeleteDTOValidator()
        {
            RuleFor(c => c.ProductId).NotEmpty().WithMessage($"{ProductStockMessagesTR.ProductStock} {BaseConstantsTR.ID} {BaseConstantsTR.NotNull}");
        }
    }
}