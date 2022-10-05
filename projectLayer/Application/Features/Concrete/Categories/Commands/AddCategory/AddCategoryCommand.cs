using AutoMapper;
using Core.Security.Results;
using eCommerceLayer.Application.Features.Base.Commands;
using eCommerceLayer.Application.Features.Concrete.Categories.Constants.Languages.TR;
using eCommerceLayer.Application.Features.Concrete.Categories.DTOs;
using eCommerceLayer.Application.Features.Concrete.Categories.Rules;
using eCommerceLayer.Domain.Entities;
using eCommerceLayer.Persistence.Concrete.Contexts;
using static Core.Application.Pipelines.Validation.ValidationTool;

namespace eCommerceLayer.Application.Features.Concrete.Categories.Commands.AddCategory
{
    public class AddCategoryCommand : ManagerBase, IAddCategoryService
    {
        ICategoryBusinessRules _categoryBusinessRules;
        public AddCategoryCommand(IMapper mapper, BaseDbContext context, ICategoryBusinessRules categoryBusinessRules) : base(mapper, context)
        {
            _categoryBusinessRules = categoryBusinessRules;
        }

        [ValidationAspect(typeof(AddCategoryDTOValidator))]
        public async Task<IResult> Add(CategoryAddDTO addedDto)
        {
            var result = _categoryBusinessRules.NameExists(addedDto.CategoryName);

            var category = Mapper.Map<Category>(result);
            await DbContext.Categories.AddAsync(category);
            await DbContext.SaveChangesAsync();
            return new SuccessResult(CategoryMessagesTR.CategoryAdded);
        }
    }
}