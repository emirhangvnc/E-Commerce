using AutoMapper;
using Core.Security.Results;
using Microsoft.EntityFrameworkCore;
using eCommerceLayer.Application.Features.Base.Constants.Languages.TR.Base;
using eCommerceLayer.Application.Features.Products.Constants.Languages.TR;
using eCommerceLayer.Application.Features.Products.DTOs;
using eCommerceLayer.Application.Services.Abstract;
using eCommerceLayer.Domain.Entities;
using eCommerceLayer.Persistence.Concrete.Contexts;
using static Core.Application.Pipelines.Validation.ValidationTool;
using eCommerceLayer.Application.Features.Products.Validations.TR;
using eCommerceLayer.Application.Features.Base.Commands;

namespace eCommerceLayer.Application.Features.Products.Rules
{
    public class ProductManager : ManagerBase, IProductService
    {
        public ProductManager(BaseDbContext context, IMapper mapper) : base(mapper, context)
        {
        }

        [ValidationAspect(typeof(ProductAddDTOValidator))]
        public async Task<IResult> Add(ProductAddDTO addedDto)
        {
            var product = Mapper.Map<Product>(addedDto);
            product.CreatedDate = DateTime.Now;
            await DbContext.Products.AddAsync(product);
            await DbContext.SaveChangesAsync();
            return new SuccessResult(ProductMessagesTR.ProductAdded);
        }

        //[SecuredOperation("product.add,admin")]
        [ValidationAspect(typeof(ProductDeleteDTOValidator))]
        public async Task<IResult> Delete(ProductDeleteDTO deletedDto)
        {
            var product = await DbContext.Products.SingleOrDefaultAsync(b => b.Id == deletedDto.Id);
            if (product == null)
                return new ErrorResult($"Böyle Bir {ProductMessagesTR.Product} {BaseConstantsTR.ID} {BaseConstantsTR.NotFound}");

            await Task.Run(() => DbContext.Products.Remove(product));
            await DbContext.SaveChangesAsync();
            return new SuccessResult(ProductMessagesTR.ProductDeleted);
        }

        [ValidationAspect(typeof(ProductUpdateDTOValidator))]
        public async Task<IResult> Update(ProductUpdateDTO updatedDto)
        {
            var result = await DbContext.Products.SingleOrDefaultAsync(b => b.Id == updatedDto.Id);
            if (result is null)
                return new ErrorResult($"Böyle Bir {ProductMessagesTR.Product} {BaseConstantsTR.ID} {BaseConstantsTR.NotFound}");

            var product = Mapper.Map<Product>(result);
            product.UpdatedDate = DateTime.Now;
            await Task.Run(() => DbContext.Products.Update(product));
            await DbContext.SaveChangesAsync();
            return new SuccessResult(ProductMessagesTR.ProductUpdated);
        }

        public async Task<IDataResult<List<Product>>> GetAll()
        {
            IQueryable<Product> result = DbContext.Set<Product>();
            var products = result.ToList();
            return new SuccessDataResult<List<Product>>(products, ProductMessagesTR.ProductsListed);
        }

        public async Task<IDataResult<Product>> GetById(int id)
        {
            var product = await DbContext.Products.SingleOrDefaultAsync(b => b.Id == id);
            if (product == null)
                return new ErrorDataResult<Product>($"{ProductMessagesTR.ProductNotFound}");
            return new SuccessDataResult<Product>(ProductMessagesTR.ProductListed);
        }
    }
}
