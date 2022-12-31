using eCommerceLayer.Application.Features.Concrete.ProductBrands.DTOs;
using FluentValidation;

namespace eCommerceLayer.Application.Features.Concrete.ProductBrands.Commands.AddProductBrand
{
    public class ProductBrandAddValidator : AbstractValidator<ProductBrandAddDTO>
    {
        public ProductBrandAddValidator()
        {
            RuleFor(p => p.ProductId).NotEmpty();
            RuleFor(p => p.BrandId).NotEmpty();
        }
    }
}