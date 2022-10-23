using eCommerceLayer.Domain.Entities;
using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Base.Commands;
using eCommerceLayer.Persistence.Concrete.Contexts;
using Microsoft.EntityFrameworkCore;
using eCommerceLayer.Application.Features.Concrete.BrandImages.Constants.Languages.TR;
using eCommerceLayer.Application.Features.Concrete.Brands.Constants.Languages.TR;

namespace eCommerceLayer.Application.Features.Concrete.BrandImages.Rules
{
    public class BrandImageBusinessRules : ManagerBase, IBrandImageBusinessRules
    {
        public BrandImageBusinessRules(IMapper mapper, BaseDbContext context) : base(mapper, context)
        {
        }

        public async Task<IDataResult<BrandImage>> IsIDExists(int id)
        {
            var result = await DbContext.BrandImages.SingleOrDefaultAsync(b => b.Id == id);
            if (result == null)
                return new ErrorDataResult<BrandImage>(BrandImageMessagesTR.BrandImageNotFound);

            return new SuccessDataResult<BrandImage>(result);
        }

        public async Task<IDataResult<Brand>> IsBrandIDExists(int id)
        {
            var result = await DbContext.Brands.SingleOrDefaultAsync(b => b.Id == id);
            if (result == null)
                return new ErrorDataResult<Brand>(BrandMessagesTR.BrandNotFound);

            return new SuccessDataResult<Brand>(result);
        }
    }
}