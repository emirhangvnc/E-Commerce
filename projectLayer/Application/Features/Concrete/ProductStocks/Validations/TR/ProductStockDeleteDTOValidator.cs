using FluentValidation;
using eCommerceLayer.Application.Features.Base.Constants.Languages.TR.Base;
using eCommerceLayer.Application.Features.Concrete.ProductStocks.Constants.Languages.TR;
using eCommerceLayer.Application.Features.Concrete.ProductStocks.DTOs;

namespace eCommerceLayer.Application.Features.Concrete.ProductStocks.Validations.TR
{
    public class ProductStockDeleteDTOValidator : AbstractValidator<ProductStockDeleteDTO>
    {
        public ProductStockDeleteDTOValidator()
        {
            RuleFor(c => c.ProductId).NotEmpty().WithMessage($"{ProductStockMessagesTR.ProductStock} {BaseConstantsTR.ID} {BaseConstantsTR.NotNull}");
        }
    }
}