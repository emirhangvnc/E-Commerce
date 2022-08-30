using AutoMapper;
using coreLayer.Aspects.Validation;
using coreLayer.Utilities.Results;
using Microsoft.EntityFrameworkCore;
using projectLayer.Application.Features.Base.Constants.Languages.TR.Base;
using projectLayer.Application.Features.Base.Rules;
using projectLayer.Application.Features.Brands.Constants.Languages.TR;
using projectLayer.Application.Features.Brands.DTOs;
using projectLayer.Application.Features.Brands.Validations.TR;
using projectLayer.Application.Features.Categories.Validations.TR;
using projectLayer.Application.Services.Abstract;
using projectLayer.Domain.Entities;
using projectLayer.Persistence.Contexts;

namespace projectLayer.Application.Features.Brands.Rules
{
    public class BrandManager : ManagerBase, IBrandService
    {
        public BrandManager(BaseDbContext context, IMapper mapper) : base(mapper, context)
        {
        }

        [ValidationAspect(typeof(BrandAddDTOValidator))]
        public async Task<IResult> Add(BrandAddDTO addedDto)
        {
            var result = await DbContext.Brands.SingleOrDefaultAsync(b => b.BrandName == addedDto.BrandName);
            if (result != null)
                return new ErrorResult($"Bu {BrandMessagesTR.Brand} {BaseConstantsTR.Name}i {BaseConstantsTR.AlreadyExists}");

            var brand = Mapper.Map<Brand>(result);
            await DbContext.Brands.AddAsync(brand);
            await DbContext.SaveChangesAsync();
            return new SuccessResult(BrandMessagesTR.BrandAdded);
        }

        [ValidationAspect(typeof(BrandDeleteDTOValidator))]
        public async Task<IResult> Delete(BrandDeleteDTO deletedDto)
        {
            var brand = await DbContext.Brands.SingleOrDefaultAsync(b => b.Id == deletedDto.Id);
            if (brand == null)
                return new ErrorResult($"Böyle Bir {BrandMessagesTR.Brand} {BaseConstantsTR.ID} {BaseConstantsTR.NotFound}");

            await Task.Run(() => DbContext.Brands.Remove(brand));
            await DbContext.SaveChangesAsync();
            return new SuccessResult(BrandMessagesTR.BrandDeleted);
        }

        [ValidationAspect(typeof(BrandUpdateDTOValidator))]
        public async Task<IResult> Update(BrandUpdateDTO updatedDto)
        {
            var result = await DbContext.Brands.SingleOrDefaultAsync(b => b.Id == updatedDto.Id);
            if (result is null)
                return new ErrorResult($"Böyle Bir {BrandMessagesTR.Brand} {BaseConstantsTR.ID} {BaseConstantsTR.NotFound}");

            var brand = Mapper.Map<Brand>(result);
            await Task.Run(() => DbContext.Brands.Update(brand));
            return new SuccessResult(BrandMessagesTR.BrandUpdated);
        }

        public async Task<IDataResult<List<Brand>>> GetAll()
        {
            IQueryable<Brand> result = DbContext.Set<Brand>();
            var brands = result.ToList();
            return new SuccessDataResult<List<Brand>>(brands, BrandMessagesTR.BrandsListed);
        }

        public async Task<IDataResult<Brand>> GetById(int id)
        {
            var brands = await DbContext.Brands.SingleOrDefaultAsync(b => b.Id == id);
            if (brands == null)
                return new ErrorDataResult<Brand>($"{BrandMessagesTR.BrandNotFound}");
            return new SuccessDataResult<Brand>(BrandMessagesTR.BrandListed);
        }
    }
}