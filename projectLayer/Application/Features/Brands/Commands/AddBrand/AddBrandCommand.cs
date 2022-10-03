using AutoMapper;
using eCommerceLayer.Application.Features.Brands.DTOs;
using eCommerceLayer.Application.Features.Brands.Rules;
using eCommerceLayer.Domain.Entities;
using eCommerceLayer.Application.Features.Brands.Commands.AddBrand;
using eCommerceLayer.Application.Features.Brands.Constants.Languages.TR;
using eCommerceLayer.Application.Features.Base.Commands;
using eCommerceLayer.Persistence.Concrete.Contexts;
using static Core.Application.Pipelines.Validation.ValidationTool;
using Core.Security.Results;

namespace eCommerceLayer.Application.Features.Brands.Commands.CreateBrand
{
    public class AddBrandCommand : ManagerBase, IAddBrandService
    {
        IBrandBusinessRules _brandBusinessRules;
        public AddBrandCommand(IMapper mapper, BaseDbContext context, IBrandBusinessRules brandBusinessRules) : base(mapper, context)
        {
            _brandBusinessRules = brandBusinessRules;
        }

        [ValidationAspect(typeof(AddBrandDTOValidator))]
        public async Task<IResult> Add(BrandAddDTO addedDto)
        {
            var result = _brandBusinessRules.BrandNameExists(addedDto.BrandName);

            var brand = Mapper.Map<Brand>(result);
            await DbContext.Brands.AddAsync(brand);
            await DbContext.SaveChangesAsync();
            return new SuccessResult(BrandMessagesTR.BrandAdded);
        }
    }
}