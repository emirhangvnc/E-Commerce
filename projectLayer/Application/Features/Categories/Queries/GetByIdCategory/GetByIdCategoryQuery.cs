using AutoMapper;
using Core.Security.Results;
using eCommerceLayer.Application.Features.Base.Commands;
using eCommerceLayer.Application.Features.Categories.Constants.Languages.TR;
using eCommerceLayer.Application.Features.Categories.DTOs;
using eCommerceLayer.Application.Features.Categories.Rules;
using eCommerceLayer.Domain.Entities;
using eCommerceLayer.Persistence.Concrete.Contexts;

namespace eCommerceLayer.Application.Features.Categories.Queries.GetByIdCategory
{
    public class GetByIdCategoryQuery : ManagerBase, IGetByIdCategoryQuery
    {
        ICategoryBusinessRules _categoryBusinessRules;
        public GetByIdCategoryQuery(IMapper mapper, BaseDbContext context, ICategoryBusinessRules categoryBusinessRules) : base(mapper, context)
        {
            _categoryBusinessRules = categoryBusinessRules;
        }

        public async Task<IDataResult<Category>> GetById(CategoryGetByIdDto categoryGetByIdDto)
        {
            var result = await _categoryBusinessRules.IsCategoryIDExists(categoryGetByIdDto.Id);

            if (result.Message != null)
                return new ErrorDataResult<Category>(result.Message);

            return new SuccessDataResult<Category>(result.Data,CategoryMessagesTR.CategoryListed);
        }
    }
}