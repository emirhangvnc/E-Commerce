using Core.CrossCuttingConcers.Exceptions;
using Core.Security.Results;
using eCommerceLayer.Application.Features.Concrete.Categories.Constants.Languages.TR;
using eCommerceLayer.Domain.Entities;
using AutoMapper;
using eCommerceLayer.Persistence.Concrete.Contexts;
using Microsoft.EntityFrameworkCore;
using eCommerceLayer.Application.Features.Base.Commands;

namespace eCommerceLayer.Application.Features.Concrete.Categories.Rules
{
    public class CategoryBusinessRules:ManagerBase, ICategoryBusinessRules
    {
        public CategoryBusinessRules(IMapper mapper, BaseDbContext context) : base(mapper, context)
        {
        }

        public async Task<IDataResult<Category>> NameExists(string name)
        {
            var result = await DbContext.Categories.SingleOrDefaultAsync(c => c.CategoryName == name);
            if (result != null)
                return new ErrorDataResult<Category>(CategoryMessagesTR.CategoryNameExists);

            return new SuccessDataResult<Category>(result);
        }

        public async Task<IDataResult<Category>> IsIDExists (int id)
        {
            var result = await DbContext.Categories.SingleOrDefaultAsync(c => c.Id == id);
            if (result == null)
                return new ErrorDataResult<Category>(CategoryMessagesTR.CategoryNotFound);

            return new SuccessDataResult<Category>(result);
        }

        public void CategoryShouldExistWhenRequested(Category category)
        {
            if (category == null) throw new BusinessException("Requested brand does not exist");
        }
    }
}