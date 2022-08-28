using FluentValidation;
using projectLayer.Application.Features.Base.Constants.Languages.TR.Base;
using projectLayer.Application.Features.Base.Constants.Languages.TR.General;
using projectLayer.Application.Features.Categories.Constants.Languages.TR;
using projectLayer.Application.Features.Products.Constants.Languages.TR;
using projectLayer.Application.Features.Products.DTOs;

namespace projectLayer.Application.Features.Products.Validations.TR
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
