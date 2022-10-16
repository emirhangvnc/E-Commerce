using FluentValidation;
using eCommerceLayer.Application.Features.Base.Constants.Languages.TR.Base;
using eCommerceLayer.Application.Features.Concrete.Products.DTOs;
using eCommerceLayer.Application.Features.Concrete.Products.Constants.Languages.TR;

namespace eCommerceLayer.Application.Features.Concrete.ProductStocks.Commands.DeleteProduct
{
    public class DeleteProductDTOValidator : AbstractValidator<ProductDeleteDTO>
    {
        public DeleteProductDTOValidator()
        {
            RuleFor(p => p.Id).NotEmpty().WithMessage($"{ProductMessagesTR.Product} {BaseConstantsTR.ID} {BaseConstantsTR.NotNull}");
        }
    }
}