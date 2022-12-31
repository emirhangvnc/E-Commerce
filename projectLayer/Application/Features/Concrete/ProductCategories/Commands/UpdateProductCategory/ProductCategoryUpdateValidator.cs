using eCommerceLayer.Application.Features.Concrete.ProductCategories.DTOs;
using FluentValidation;

namespace eCommerceLayer.Application.Features.Concrete.ProductCategories.Commands.UpdateProductCategory
{
    public class ProductCategoryUpdateValidator : AbstractValidator<ProductCategoryUpdateDTO>
    {
        public ProductCategoryUpdateValidator()
        {
            RuleFor(p => p.Id).NotEmpty();
            RuleFor(p => p.ProductId).NotEmpty();
            RuleFor(p => p.CategoryId).NotEmpty();
        }
    }
}