using eCommerceLayer.Application.Features.Concrete.ProductCategories.DTOs;
using FluentValidation;

namespace eCommerceLayer.Application.Features.Concrete.ProductCategories.Commands.AddProductCategory
{
    public class ProductCategoryAddValidator : AbstractValidator<ProductCategoryAddDTO>
    {
        public ProductCategoryAddValidator()
        {
            RuleFor(p => p.ProductId).NotEmpty();
            RuleFor(p => p.CategoryId).NotEmpty();
        }
    }
}