using FluentValidation;
using eCommerceLayer.Application.Features.Base.Constants.Languages.TR.Base;
using eCommerceLayer.Application.Features.Base.Constants.Languages.TR.General;
using eCommerceLayer.Application.Features.Concrete.Categories.Constants.Languages.TR;
using eCommerceLayer.Application.Features.Concrete.Products.Constants.Languages.TR;
using eCommerceLayer.Application.Features.Concrete.Products.DTOs;

namespace eCommerceLayer.Application.Features.Concrete.Products.Commands.AddProduct
{
    public class AddProductDTOValidator : AbstractValidator<ProductAddDTO>
    {
        public AddProductDTOValidator()
        {
            RuleFor(c => c.ProductName).NotEmpty().WithMessage($"{ProductMessagesTR.ProductNameNotNull}");
            RuleFor(c => c.ProductName).MaximumLength(50).WithMessage($"{ProductMessagesTR.Product} {BaseConstantsTR.Name} {GeneralConstantsTR.Max50Character}");
            RuleFor(c => c.CategoryId).NotEmpty().WithMessage($"{CategoryMessagesTR.Category} {BaseConstantsTR.ID} {BaseConstantsTR.NotNull}");
        }
    }
}
