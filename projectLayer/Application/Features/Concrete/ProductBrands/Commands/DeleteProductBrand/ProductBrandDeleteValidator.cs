using eCommerceLayer.Application.Features.Concrete.ProductBrands.DTOs;
using FluentValidation;

namespace eCommerceLayer.Application.Features.Concrete.ProductBrands.Commands.DeleteProductBrand
{
    public class ProductBrandDeleteValidator : AbstractValidator<ProductBrandDeleteDTO>
    {
        public ProductBrandDeleteValidator()
        {
            RuleFor(f => f.Id).NotEmpty();
        }
    }
}