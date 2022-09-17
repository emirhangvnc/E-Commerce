using FluentValidation;
using eCommerceLayer.Application.Features.Base.Constants.Languages.TR.Base;
using eCommerceLayer.Application.Features.Categories.Constants.Languages.TR;
using eCommerceLayer.Application.Features.Categories.DTOs;

namespace eCommerceLayer.Application.Features.Categories.Validations.TR
{
    public class CategoryDeleteDTOValidator : AbstractValidator<CategoryDeleteDTO>
    {
        public CategoryDeleteDTOValidator()
        {
            RuleFor(c => c.Id).NotEmpty().WithMessage($"{CategoryMessagesTR.Category} {BaseConstantsTR.ID} {BaseConstantsTR.NotNull}");
        }
    }
}
