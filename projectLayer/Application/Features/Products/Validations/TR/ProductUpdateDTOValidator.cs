using FluentValidation;
using eCommerceLayer.Application.Features.Products.DTOs;

namespace eCommerceLayer.Application.Features.Products.Validations.TR
{
    public class ProductUpdateDTOValidator : AbstractValidator<ProductUpdateDTO>
    {
        public ProductUpdateDTOValidator()
        {
        }
    }
}
