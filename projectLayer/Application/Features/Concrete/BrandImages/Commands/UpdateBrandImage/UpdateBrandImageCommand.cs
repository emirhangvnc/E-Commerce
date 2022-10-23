using AutoMapper;
using Core.Utilities.Helpers.FileUpload;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Base.Commands;
using eCommerceLayer.Application.Features.Concrete.BrandImages.Constants.Languages.TR;
using eCommerceLayer.Application.Features.Concrete.BrandImages.DTOs;
using eCommerceLayer.Application.Features.Concrete.BrandImages.Rules;
using eCommerceLayer.Domain.Entities;
using eCommerceLayer.Persistence.Concrete.Contexts;
using static Core.Application.Pipelines.Validation.ValidationTool;

namespace eCommerceLayer.Application.Features.Concrete.BrandImages.Commands.UpdateBrandImage
{
    public class UpdateBrandImageCommand : ManagerBase, IUpdateBrandImageService
    {
        IBrandImageBusinessRules _brandImageBusinessRules;
        public UpdateBrandImageCommand(IMapper mapper, BaseDbContext context, IBrandImageBusinessRules brandImageBusinessRules) : base(mapper, context)
        {
            _brandImageBusinessRules = brandImageBusinessRules;
        }

        [ValidationAspect(typeof(UpdateBrandImageDTOValidator))]
        public async Task<IResult> Update(BrandImageUpdateDTO updatedDTO)
        {
            var result = _brandImageBusinessRules.IsIDExists(updatedDTO.ID);
            if (result.Result.Message != null)
                return new ErrorResult(result.Result.Message);

            var isBrand = _brandImageBusinessRules.IsBrandIDExists(updatedDTO.BrandId);
            if (!isBrand.Result.Success)
                return new ErrorResult(isBrand.Result.Message);

            var updatedFile = FileUpload.Update(updatedDTO.File, result.Result.Data.FilePath);
            if (!updatedFile.Success)
                return new ErrorResult(updatedFile.Message);

            var brandImage = Mapper.Map<BrandImage>(updatedDTO);
            brandImage.UpdatedDate = DateTime.Now;
            brandImage.FileName = updatedDTO.File.FileName;
            brandImage.FilePath = updatedFile.Message;

            await Task.Run(() => DbContext.BrandImages.Update(brandImage));
            await DbContext.SaveChangesAsync();
            return new SuccessResult(BrandImageMessagesTR.BrandImageUpdated);
        }
    }
}