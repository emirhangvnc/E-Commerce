using FluentValidation;
using eCommerceLayer.Application.Features.Base.Constants.Languages.TR.Base;
using eCommerceLayer.Application.Features.Categories.Constants.Languages.TR;
using eCommerceLayer.Application.Features.Categories.DTOs;

namespace eCommerceLayer.Application.Features.Categories.Commands.DeleteCategory
{
    public class DeleteCategoryDTOValidator : AbstractValidator<CategoryDeleteDTO>
    {
        public DeleteCategoryDTOValidator()
        {
            RuleFor(c => c.Id).NotEmpty().WithMessage($"{CategoryMessagesTR.Category} {BaseConstantsTR.ID} {BaseConstantsTR.NotNull}");
        }
    }
}
