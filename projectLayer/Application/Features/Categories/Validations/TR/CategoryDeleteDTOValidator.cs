using FluentValidation;
using projectLayer.Application.Features.Base.Constants.Languages.TR.Base;
using projectLayer.Application.Features.Categories.Constants.Languages.TR;
using projectLayer.Application.Features.Categories.DTOs;

namespace projectLayer.Application.Features.Categories.Validations.TR
{
    public class CategoryDeleteDTOValidator : AbstractValidator<CategoryDeleteDTO>
    {
        public CategoryDeleteDTOValidator()
        {
            RuleFor(c => c.Id).NotEmpty().WithMessage($"{CategoryMessagesTR.Category} {BaseConstantsTR.ID} {BaseConstantsTR.NotNull}");
        }
    }
}
