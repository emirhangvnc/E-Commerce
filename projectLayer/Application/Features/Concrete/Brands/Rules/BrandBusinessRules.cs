using eCommerceLayer.Application.Features.Concrete.Brands.Constants.Languages.TR;
using eCommerceLayer.Domain.Entities;
using Core.CrossCuttingConcers.Exceptions;
using AutoMapper;
using Core.Security.Results;
using eCommerceLayer.Application.Features.Base.Commands;
using eCommerceLayer.Persistence.Concrete.Contexts;
using Microsoft.EntityFrameworkCore;

namespace eCommerceLayer.Application.Features.Concrete.Brands.Rules
{
    public class BrandBusinessRules : ManagerBase, IBrandBusinessRules
    {
        public BrandBusinessRules(IMapper mapper, BaseDbContext context) : base(mapper, context)
        {
        }

        public async Task<IDataResult<Brand>> NameExists(string name)
        {
            var result = await DbContext.Brands.SingleOrDefaultAsync(b => b.BrandName == name);
            if (result != null)
                return new ErrorDataResult<Brand>(BrandMessagesTR.BrandNameExists);

            return new SuccessDataResult<Brand>(result);
        }

        public async Task<IDataResult<Brand>> IsIDExists(int id)
        {
            var result = await DbContext.Brands.SingleOrDefaultAsync(c => c.Id == id);
            if (result == null)
                return new ErrorDataResult<Brand>(BrandMessagesTR.BrandNotFound);

            return new SuccessDataResult<Brand>(result);
        }

        public void BrandShouldExistWhenRequested(Brand brand)
        {
            if (brand == null) throw new BusinessException("Requested brand does not exist");
        }
    }
}