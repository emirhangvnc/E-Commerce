using AutoMapper;
using coreLayer.Aspects.Validation;
using coreLayer.Utilities.Results;
using projectLayer.Application.Features.Base.Rules;
using projectLayer.Application.Features.Categories.DTOs;
using projectLayer.Application.Features.Categories.Validations.TR;
using projectLayer.Application.Services.Abstract;
using projectLayer.Domain.Entities;
using projectLayer.Persistence.Contexts;

namespace projectLayer.Application.Features.Categories.Rules
{
    public class CategoryManager : ManagerBase, ICategoryService
    {
        public CategoryManager(BaseDbContext context, IMapper mapper) : base(mapper, context)
        {
        }
        [ValidationAspect(typeof(CategoryAddDTOValidator))]
        public Task<IResult> Add(CategoryAddDTO addedDto)
        {
            throw new NotImplementedException();
        }
        [ValidationAspect(typeof(CategoryDeleteDTOValidator))]
        public Task<IResult> Delete(CategoryDeleteDTO deletedDto)
        {
            throw new NotImplementedException();
        }
        [ValidationAspect(typeof(CategoryUpdateDTOValidator))]
        public Task<IResult> Update(CategoryUpdateDTO updatedDto)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<List<Category>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<Category>> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}