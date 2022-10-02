using FluentValidation;
using eCommerceLayer.Application.Features.Base.Constants.Languages.TR.Base;
using eCommerceLayer.Application.Features.Base.Constants.Languages.TR.General;
using eCommerceLayer.Application.Features.Categories.Constants.Languages.TR;
using eCommerceLayer.Application.Features.Categories.DTOs;

namespace eCommerceLayer.Application.Features.Categories.Commands.UpdateCategory
{
    public class UpdateCategoryDTOValidator : AbstractValidator<CategoryUpdateDTO>
    {
        public UpdateCategoryDTOValidator()
        {
            RuleFor(c => c.Id).NotEmpty().WithMessage($"{CategoryMessagesTR.Category} {BaseConstantsTR.ID} {BaseConstantsTR.NotNull}");
            RuleFor(c => c.CategoryName).NotEmpty().WithMessage($"{CategoryMessagesTR.Category} {BaseConstantsTR.Name} {BaseConstantsTR.NotNull}");
            RuleFor(c => c.CategoryName).MaximumLength(20).WithMessage($"{CategoryMessagesTR.Category} {BaseConstantsTR.Name} {GeneralConstantsTR.Max30Character}");
        }
    }
}
