using AutoMapper;
using Core.Utilities.Helpers.FileUpload;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Base.Commands;
using eCommerceLayer.Application.Features.Concrete.BrandImages.Constants.Languages.TR;
using eCommerceLayer.Application.Features.Concrete.BrandImages.DTOs;
using eCommerceLayer.Application.Features.Concrete.BrandImages.Rules;
using eCommerceLayer.Application.Features.Concrete.Brands.Constants.Languages.TR;
using eCommerceLayer.Domain.Entities;
using eCommerceLayer.Persistence.Concrete.Contexts;
using Microsoft.EntityFrameworkCore;
using static Core.Application.Pipelines.Validation.ValidationTool;

namespace eCommerceLayer.Application.Features.Concrete.BrandImages.Commands.AddBrandImage
{
    public class AddBrandImageCommand : ManagerBase, IAddBrandImageService
    {
        IBrandImageBusinessRules _brandImageBusinessRules;
        public AddBrandImageCommand(IMapper mapper, BaseDbContext context, IBrandImageBusinessRules brandImageBusinessRules) : base(mapper, context)
        {
            _brandImageBusinessRules = brandImageBusinessRules;
        }

        [ValidationAspect(typeof(AddBrandImageDTOValidator))]
        public async Task<IResult> Upload(BrandImageUploadDTO addedDto)
        {
            var result = FileUpload.Upload(addedDto.File);
            if (!result.Success)
                return new ErrorResult(result.Message);

            var image = _brandImageBusinessRules.IsBrandIDExists(addedDto.BrandId);
            if (!image.Result.Success)
                return new ErrorResult(image.Result.Message);

            var brandImage = Mapper.Map<BrandImage>(addedDto);
            brandImage.CreatedDate=DateTime.Now;
            brandImage.UpdatedDate = DateTime.Now;
            brandImage.FileName=addedDto.File.FileName;
            brandImage.FileName = result.Message;

            await DbContext.BrandImages.AddAsync(brandImage);
            await DbContext.SaveChangesAsync();
            return new SuccessResult(BrandImageMessagesTR.BrandImageAdded);
        }
    }
}