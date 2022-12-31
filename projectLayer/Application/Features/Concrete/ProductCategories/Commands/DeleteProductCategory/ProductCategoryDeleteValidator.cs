using eCommerceLayer.Application.Features.Concrete.ProductCategories.DTOs;
using FluentValidation;

namespace eCommerceLayer.Application.Features.Concrete.ProductCategories.Commands.DeleteProductCategory
{
    public class ProductCategoryDeleteValidator : AbstractValidator<ProductCategoryDeleteDTO>
    {
        public ProductCategoryDeleteValidator()
        {
            RuleFor(f => f.Id).NotEmpty();
        }
    }
}