using AutoMapper;
using eCommerceLayer.Application.Features.Concrete.Brands.DTOs;
using eCommerceLayer.Application.Features.Concrete.Brands.Rules;
using eCommerceLayer.Domain.Entities;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Base.Commands;
using eCommerceLayer.Persistence.Concrete.Contexts;
using static Core.Application.Pipelines.Validation.ValidationTool;
using eCommerceLayer.Application.Features.Concrete.Brands.Constants.Languages.TR;

namespace eCommerceLayer.Application.Features.Concrete.Brands.Commands.DeleteBrand
{
    public class DeleteBrandCommand : ManagerBase, IDeleteBrandService
    {
        IBrandBusinessRules _brandBusinessRules;
        public DeleteBrandCommand(BaseDbContext context, IMapper mapper, IBrandBusinessRules brandBusinessRules) : base(mapper, context)
        {
            _brandBusinessRules = brandBusinessRules;
        }

        [ValidationAspect(typeof(DeleteBrandDTOValidator))]
        public async Task<IResult> Delete(BrandDeleteDTO deletedDto)
        {
            var result = _brandBusinessRules.IsIDExists(deletedDto.Id);

            if (result.Result.Message != null)
                return new ErrorResult(result.Result.Message);

            var brand = Mapper.Map<Brand>(result);
            await Task.Run(() => DbContext.Brands.Remove(brand));
            await DbContext.SaveChangesAsync();
            return new SuccessResult($"{result.Result.Data.BrandName} {BrandMessagesTR.BrandAdded}");
        }
    }
}