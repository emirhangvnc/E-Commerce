using AutoMapper;
using Core.Application.Requests;
using Core.Security.Results;
using eCommerceLayer.Application.Features.Base.Commands;
using eCommerceLayer.Application.Features.Categories.Constants.Languages.TR;
using eCommerceLayer.Application.Features.Categories.Models;
using eCommerceLayer.Application.Features.Categories.Rules;
using eCommerceLayer.Domain.Entities;
using eCommerceLayer.Persistence.Concrete.Contexts;
using eCommerceLayer.Persistence.Services.Repositories;

namespace eCommerceLayer.Application.Features.Categories.Queries.GetListBrand
{
    public class GetAllCategoryQuery : ManagerBase, IGetAllCategoryQuery
    {
        ICategoryBusinessRules _categoryBusinessRules;
        ICategoryRepository _categoryRepository;
        public GetAllCategoryQuery(IMapper mapper, BaseDbContext context, ICategoryBusinessRules categoryBusinessRules, ICategoryRepository categoryRepository) : base(mapper, context)
        {
            _categoryBusinessRules = categoryBusinessRules;
            _categoryRepository = categoryRepository;
        }

        public async Task<IDataResult<Category>> GetById(PageRequest request)
        {
            var result = await _categoryRepository.GetListAsync(index: request.Page, size: request.PageSize);

            if (result.Items.Count<=0)
                return new ErrorDataResult<Category>(CategoryMessagesTR.CategoryNotFound);


            var mappedCategoryListModel = Mapper.Map<CategoryListModel>(result);

            return new SuccessDataResult<Category>();
        }
    }
}