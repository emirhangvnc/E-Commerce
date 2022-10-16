using FluentValidation;
using eCommerceLayer.Application.Features.Concrete.Products.DTOs;

namespace eCommerceLayer.Application.Features.Concrete.Products.Commands.UpdateProduct
{
    public class UpdateProductDTOValidator : AbstractValidator<ProductUpdateDTO>
    {
        public UpdateProductDTOValidator()
        {
        }
    }
}
