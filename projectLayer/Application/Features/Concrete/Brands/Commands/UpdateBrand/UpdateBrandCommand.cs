using AutoMapper;
using Core.Security.Results;
using eCommerceLayer.Application.Features.Base.Commands;
using eCommerceLayer.Application.Features.Concrete.Brands.Constants.Languages.TR;
using eCommerceLayer.Application.Features.Concrete.Brands.DTOs;
using eCommerceLayer.Application.Features.Concrete.Brands.Rules;
using eCommerceLayer.Domain.Entities;
using eCommerceLayer.Persistence.Concrete.Contexts;
using static Core.Application.Pipelines.Validation.ValidationTool;

namespace eCommerceLayer.Application.Features.Concrete.Brands.Commands.UpdateBrand
{
    public class UpdateBrandCommand : ManagerBase, IUpdateBrandService
    {
        IBrandBusinessRules _brandBusinessRules;
        public UpdateBrandCommand(BaseDbContext context, IMapper mapper, IBrandBusinessRules brandBusinessRules) : base(mapper, context)
        {
            _brandBusinessRules = brandBusinessRules;
        }

        [ValidationAspect(typeof(UpdateBrandDTOValidator))]
        public async Task<IResult> Update(BrandUpdateDTO updateDto)
        {
            var result = _brandBusinessRules.IsIDExists(updateDto.Id);

            if (result.Result.Message != null)
                return new ErrorResult(result.Result.Message);

            var brand = Mapper.Map<Brand>(result);
            await Task.Run(() => DbContext.Brands.Update(brand));
            await DbContext.SaveChangesAsync();
            return new SuccessResult(BrandMessagesTR.BrandUpdated);
        }
    }
}