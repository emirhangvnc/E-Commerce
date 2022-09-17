using FluentValidation;
using eCommerceLayer.Application.Features.Base.Constants.Languages.TR.Base;
using eCommerceLayer.Application.Features.Base.Constants.Languages.TR.General;
using eCommerceLayer.Application.Features.Categories.Constants.Languages.TR;
using eCommerceLayer.Application.Features.Products.Constants.Languages.TR;
using eCommerceLayer.Application.Features.Products.DTOs;

namespace eCommerceLayer.Application.Features.Products.Validations.TR
{
    public class ProductAddDTOValidator : AbstractValidator<ProductAddDTO>
    {
        public ProductAddDTOValidator()
        {
            RuleFor(c => c.ProductName).NotEmpty().WithMessage($"{ProductMessagesTR.Product} {BaseConstantsTR.Name} {BaseConstantsTR.NotNull}");
            RuleFor(c => c.ProductName).MaximumLength(30).WithMessage($"{ProductMessagesTR.Product} {BaseConstantsTR.Name} {GeneralConstantsTR.Max50Character}");
            RuleFor(c => c.CategoryId).NotEmpty().WithMessage($"{CategoryMessagesTR.Category} {BaseConstantsTR.ID} {BaseConstantsTR.NotNull}");
        }
    }
}
