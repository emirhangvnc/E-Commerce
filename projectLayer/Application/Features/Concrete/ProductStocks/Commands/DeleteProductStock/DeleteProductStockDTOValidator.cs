using FluentValidation;
using eCommerceLayer.Application.Features.Base.Constants.Languages.TR.Base;
using eCommerceLayer.Application.Features.Concrete.ProductStocks.Constants.Languages.TR;
using eCommerceLayer.Application.Features.Concrete.ProductStocks.DTOs;

namespace eCommerceLayer.Application.Features.Concrete.ProductStocks.Commands.DeleteProductStock
{
    public class DeleteProductStockDTOValidator : AbstractValidator<ProductStockDeleteDTO>
    {
        public DeleteProductStockDTOValidator()
        {
            RuleFor(c => c.ProductId).NotEmpty().WithMessage($"{ProductStockMessagesTR.ProductStock} {BaseConstantsTR.ID} {BaseConstantsTR.NotNull}");
        }
    }
}