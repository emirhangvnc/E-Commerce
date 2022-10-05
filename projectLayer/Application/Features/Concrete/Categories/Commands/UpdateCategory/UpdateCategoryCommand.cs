using AutoMapper;
using Core.Security.Results;
using eCommerceLayer.Application.Features.Base.Commands;
using eCommerceLayer.Application.Features.Concrete.Categories.Constants.Languages.TR;
using eCommerceLayer.Application.Features.Concrete.Categories.DTOs;
using eCommerceLayer.Application.Features.Concrete.Categories.Rules;
using eCommerceLayer.Domain.Entities;
using eCommerceLayer.Persistence.Concrete.Contexts;
using static Core.Application.Pipelines.Validation.ValidationTool;

namespace eCommerceLayer.Application.Features.Concrete.Categories.Commands.UpdateCategory
{
    public class UpdateCategoryCommand : ManagerBase, IUpdateCategoryService
    {
        private readonly CategoryBusinessRules _categoryBusinessRules;
        public UpdateCategoryCommand(BaseDbContext context, IMapper mapper, CategoryBusinessRules categoryBusinessRules) : base(mapper, context)
        {
            _categoryBusinessRules = categoryBusinessRules;
        }

        [ValidationAspect(typeof(UpdateCategoryDTOValidator))]
        public async Task<IResult> Update(CategoryUpdateDTO updateDto)
        {
            var result = _categoryBusinessRules.IsIDExists(updateDto.Id);

            if (result.Result.Message != null)
                return new ErrorResult(result.Result.Message);

            var category = Mapper.Map<Category>(result);
            await Task.Run(() => DbContext.Categories.Update(category));
            await DbContext.SaveChangesAsync();
            return new SuccessResult(CategoryMessagesTR.CategoryUpdated);
        }
    }
}