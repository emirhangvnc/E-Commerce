﻿using AutoMapper;
using coreLayer.Aspects.Caching;
using coreLayer.Aspects.Validation;
using coreLayer.Utilities.Results;
using Microsoft.EntityFrameworkCore;
using projectLayer.Application.Features.Base.Constants.Languages.TR.Base;
using projectLayer.Application.Features.Base.Rules;
using projectLayer.Application.Features.Categories.Validations.TR;
using projectLayer.Application.Features.Products.Constants.Languages.TR;
using projectLayer.Application.Features.Products.DTOs;
using projectLayer.Application.Services.Abstract;
using projectLayer.Domain.Entities;
using projectLayer.Persistence.Contexts;

namespace Application.Features.Products.Rules
{
    public class ProductManager : ManagerBase, IProductService
    {
        public ProductManager(BaseDbContext context, IMapper mapper) : base(mapper, context)
        {
        }

        [ValidationAspect(typeof(CategoryAddDTOValidator))]
        [CacheRemoveAspect("IProductService.Get")]
        public async Task<IResult> Add(ProductAddDTO addedDto)
        {
            //var product = Mapper.Map<Brand>(result);
            //await DbContext.Brands.AddAsync(product);
            await DbContext.SaveChangesAsync();
            return new SuccessResult(ProductMessagesTR.ProductAdded);
        }

        //[SecuredOperation("product.add,admin")]
        [ValidationAspect(typeof(CategoryDeleteDTOValidator))]
        [CacheRemoveAspect("IProductService.Get")]
        public async Task<IResult> Delete(ProductDeleteDTO deletedDto)
        {
            var product = await DbContext.Products.SingleOrDefaultAsync(b => b.Id == deletedDto.Id);
            if (product == null)
                return new ErrorResult($"Böyle Bir {ProductMessagesTR.Product} {BaseConstantsTR.ID} {BaseConstantsTR.NotFound}");

            await Task.Run(() => DbContext.Products.Remove(product));
            await DbContext.SaveChangesAsync();
            return new SuccessResult(ProductMessagesTR.ProductDeleted);
        }

        [ValidationAspect(typeof(CategoryUpdateDTOValidator))]
        [CacheRemoveAspect("IProductService.Get")]
        public async Task<IResult> Update(ProductUpdateDTO updatedDto)
        {
            var result = await DbContext.Products.SingleOrDefaultAsync(b => b.Id == updatedDto.Id);
            if (result is null)
                return new ErrorResult($"Böyle Bir {ProductMessagesTR.Product} {BaseConstantsTR.ID} {BaseConstantsTR.NotFound}");

            var product = Mapper.Map<Product>(result);
            await Task.Run(() => DbContext.Products.Update(product));
            return new SuccessResult(ProductMessagesTR.ProductUpdated);
        }

        [CacheAspect]
        public async Task<IDataResult<List<Product>>> GetAll()
        {
            IQueryable<Product> result = DbContext.Set<Product>();
            var products = result.ToList();
            return new SuccessDataResult<List<Product>>(products, ProductMessagesTR.ProductsListed);
        }

        [CacheAspect]
        public async Task<IDataResult<Product>> GetById(int id)
        {
            var product = await DbContext.Products.SingleOrDefaultAsync(b => b.Id == id);
            if (product == null)
                return new ErrorDataResult<Product>($"{ProductMessagesTR.ProductNotFound}");
            return new SuccessDataResult<Product>(ProductMessagesTR.ProductListed);
        }
    }
}