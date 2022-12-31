using eCommerceLayer.Application.Features.Concrete.ProductBrands.DTOs;
using eCommerceLayer.Application.Features.Concrete.ProductCategories.DTOs;
using FluentValidation;

namespace eCommerceLayer.Application.Features.Concrete.ProductBrands.Commands.UpdateProductBrand
{
    public class ProductBrandUpdateValidator : AbstractValidator<ProductBrandUpdateDTO>
    {
        public ProductBrandUpdateValidator()
        {
            RuleFor(p => p.Id).NotEmpty();
            RuleFor(p => p.ProductId).NotEmpty();
            RuleFor(p => p.BrandId).NotEmpty();
        }
    }
}