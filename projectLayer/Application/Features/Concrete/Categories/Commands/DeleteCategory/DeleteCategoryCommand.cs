using AutoMapper;
using Core.Security.Results;
using eCommerceLayer.Application.Features.Base.Commands;
using eCommerceLayer.Application.Features.Concrete.Categories.Constants.Languages.TR;
using eCommerceLayer.Application.Features.Concrete.Categories.DTOs;
using eCommerceLayer.Application.Features.Concrete.Categories.Rules;
using eCommerceLayer.Domain.Entities;
using eCommerceLayer.Persistence.Concrete.Contexts;
using static Core.Application.Pipelines.Validation.ValidationTool;

namespace eCommerceLayer.Application.Features.Concrete.Categories.Commands.DeleteCategory
{
    public class DeleteCategoryCommand : ManagerBase, IDeleteCategoryService
    {
        ICategoryBusinessRules _categoryBusinessRules;
        public DeleteCategoryCommand(BaseDbContext context, IMapper mapper, ICategoryBusinessRules categoryBusinessRules) : base(mapper, context)
        {
            _categoryBusinessRules = categoryBusinessRules;
        }

        [ValidationAspect(typeof(DeleteCategoryDTOValidator))]
        public async Task<IResult> Delete(CategoryDeleteDTO addedDto)
        {
            var result = _categoryBusinessRules.IsIDExists(addedDto.Id);

            if (result.Result.Message != null)
                return new ErrorResult(result.Result.Message);

            var category = Mapper.Map<Category>(result);
            await Task.Run(() => DbContext.Categories.Remove(category));
            await DbContext.SaveChangesAsync();
            return new SuccessResult($"{result.Result.Data.CategoryName} {CategoryMessagesTR.CategoryAdded}");
        }
    }
}