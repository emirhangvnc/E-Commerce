using AutoMapper;
using Core.Security.Results;
using Microsoft.EntityFrameworkCore;
using projectLayer.Application.Features.Base.Constants.Languages.TR.Base;
using projectLayer.Application.Features.Base.Rules;
using projectLayer.Application.Features.Categories.Constants.Languages.TR;
using projectLayer.Application.Features.Categories.DTOs;
using projectLayer.Application.Features.Categories.Validations.TR;
using projectLayer.Application.Services.Abstract;
using projectLayer.Domain.Entities;
using projectLayer.Persistence.Contexts;
using static Core.Application.Pipelines.Validation.ValidationTool;

namespace projectLayer.Application.Features.Categories.Rules
{
    public class CategoryManager : ManagerBase, ICategoryService
    {
        public CategoryManager(BaseDbContext context, IMapper mapper) : base(mapper, context)
        {
        }

        [ValidationAspect(typeof(CategoryAddDTOValidator))]
        public async Task<IResult> Add(CategoryAddDTO addedDto)
        {
            var result = await DbContext.Categories.SingleOrDefaultAsync(c => c.CategoryName == addedDto.CategoryName);
            if (result != null)
                return new ErrorResult($"Bu {BaseConstantsTR.Name}de Bir {CategoryMessagesTR.Category} { BaseConstantsTR.AlreadyExists}");

            var category = Mapper.Map<Category>(result);
            await DbContext.Categories.AddAsync(category);
            await DbContext.SaveChangesAsync();
            return new SuccessResult(CategoryMessagesTR.CategoryAdded);
        }

        [ValidationAspect(typeof(CategoryDeleteDTOValidator))]
        public async Task<IResult> Delete(CategoryDeleteDTO deletedDto)
        {
            var category = await DbContext.Categories.SingleOrDefaultAsync(c => c.Id == deletedDto.Id);
            if (category == null)
                return new ErrorResult($"Böyle Bir {CategoryMessagesTR.Category} {BaseConstantsTR.ID} {BaseConstantsTR.NotFound}");

            await Task.Run(() => DbContext.Categories.Remove(category));
            await DbContext.SaveChangesAsync();
            return new SuccessResult(CategoryMessagesTR.CategoryDeleted);
        }

        [ValidationAspect(typeof(CategoryUpdateDTOValidator))]
        public async Task<IResult> Update(CategoryUpdateDTO updatedDto)
        {
            var result = await DbContext.Categories.SingleOrDefaultAsync(c => c.Id == updatedDto.Id);
            if (result is null)
                return new ErrorResult($"Böyle Bir {CategoryMessagesTR.Category} {BaseConstantsTR.ID} {BaseConstantsTR.NotFound}");

            var category = Mapper.Map<Category>(result);
            await Task.Run(() => DbContext.Categories.Update(category));
            await DbContext.SaveChangesAsync();
            return new SuccessResult(CategoryMessagesTR.CategoryUpdated);
        }

        public async Task<IDataResult<List<Category>>> GetAll()
        {
            IQueryable<Category> result = DbContext.Set<Category>();
            var categories = result.ToList();
            return new SuccessDataResult<List<Category>>(categories, CategoryMessagesTR.CategoriesListed);
        }

        public async Task<IDataResult<Category>> GetById(int id)
        {
            var categories = await DbContext.Categories.SingleOrDefaultAsync(a => a.Id == id);
            if (categories == null)
                return new ErrorDataResult<Category>($"{CategoryMessagesTR.CategoryNotFound}");
            return new SuccessDataResult<Category>(CategoryMessagesTR.CategoryListed);
        }
    }
}