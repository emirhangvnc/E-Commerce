using AutoMapper;
using eCommerceLayer.Application.Features.Concrete.Brands.DTOs;
using eCommerceLayer.Application.Features.Concrete.Brands.Rules;
using eCommerceLayer.Domain.Entities;
using Core.Security.Results;
using eCommerceLayer.Application.Features.Base.Commands;
using eCommerceLayer.Persistence.Concrete.Contexts;
using eCommerceLayer.Application.Features.Concrete.Brands.Constants.Languages.TR;

namespace eCommerceLayer.Application.Features.Concrete.Brands.Queries.GetByIdBrand
{
    public class GetByIdBrandQuery : ManagerBase, IGetByIdBrandQuery
    {
        IBrandBusinessRules _brandBusinessRules;
        public GetByIdBrandQuery(IMapper mapper, BaseDbContext context, IBrandBusinessRules brandBusinessRules) : base(mapper, context)
        {
            _brandBusinessRules = brandBusinessRules;
        }

        public async Task<IDataResult<Brand>> GetById(BrandGetByIdDto brandGetByIdDto)
        {
            var result = await _brandBusinessRules.IsIDExists(brandGetByIdDto.Id);

            if (result.Data == null)
                return new ErrorDataResult<Brand>(result.Message);

            return new SuccessDataResult<Brand>(result.Data, BrandMessagesTR.BrandListed);
        }
    }
}