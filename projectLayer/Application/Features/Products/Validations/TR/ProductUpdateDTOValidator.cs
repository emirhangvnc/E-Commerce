using FluentValidation;
using projectLayer.Application.Features.Products.DTOs;

namespace projectLayer.Application.Features.Products.Validations.TR
{
    public class ProductUpdateDTOValidator : AbstractValidator<ProductUpdateDTO>
    {
        public ProductUpdateDTOValidator()
        {
        }
    }
}
