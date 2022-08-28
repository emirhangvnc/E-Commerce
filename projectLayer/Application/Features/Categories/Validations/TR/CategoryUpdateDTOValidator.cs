using FluentValidation;
using projectLayer.Application.Features.Base.Constants.Languages.TR.Base;
using projectLayer.Application.Features.Base.Constants.Languages.TR.General;
using projectLayer.Application.Features.Categories.Constants.Languages.TR;
using projectLayer.Application.Features.Categories.DTOs;

namespace projectLayer.Application.Features.Categories.Validations.TR
{
    public class CategoryUpdateDTOValidator : AbstractValidator<CategoryUpdateDTO>
    {
        public CategoryUpdateDTOValidator()
        {
            RuleFor(c => c.Id).NotEmpty().WithMessage($"{CategoryMessagesTR.Category} {BaseConstantsTR.ID} {BaseConstantsTR.NotNull}");
            RuleFor(c => c.CategoryName).NotEmpty().WithMessage($"{CategoryMessagesTR.Category} {BaseConstantsTR.Name} {BaseConstantsTR.NotNull}");
            RuleFor(c => c.CategoryName).MaximumLength(20).WithMessage($"{CategoryMessagesTR.Category} {BaseConstantsTR.Name} {GeneralConstantsTR.Max50Character}");
        }
    }
}
