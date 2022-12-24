using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Base.Commands;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.Categories.Rules
{
    public class CategoryBusinessRules : ManagerBase, ICategoryBusinessRules
    {
        ICategoryRepository _categoryRepository;
        public CategoryBusinessRules(IMapper mapper, ICategoryRepository categoryRepository) : base(mapper)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<IResult> CategoryNameExists(string name)
        {
            var result = await _categoryRepository.GetAsync(f => f.CategoryName == name);
            if (result != null && result.Status==true)
                return new ErrorResult($"Category Name {result.Id} Used by ID Number");
            return new SuccessResult();
        }

        public async Task<IDataResult<Category>> IsIDExists(int id)
        {
            var result = await _categoryRepository.GetAsync(c => c.Id == id);
            if (result == null)
                return new ErrorDataResult<Category>("Category Not Found");

            return new SuccessDataResult<Category>(result);
        }
    }
}