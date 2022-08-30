using AutoMapper;
using coreLayer.Utilities.Results;
using Microsoft.EntityFrameworkCore;
using projectLayer.Application.Features.Base.Constants.Languages.TR.Base;
using projectLayer.Application.Features.Base.Rules;
using projectLayer.Application.Features.Products.Constants.Languages.TR;
using projectLayer.Application.Features.ProductStocks.Constants.Languages.TR;
using projectLayer.Application.Features.ProductStocks.DTOs;
using projectLayer.Application.Services.Abstract;
using projectLayer.Domain.Entities;
using projectLayer.Persistence.Contexts;

namespace projectLayer.Application.Features.ProductStocks.Rules
{
    public class ProductStockManager : ManagerBase, IProductStockService
    {
        public ProductStockManager(BaseDbContext context, IMapper mapper) : base(mapper, context)
        {
        }

        public async Task<IResult> Add(ProductStockAddDTO addedDto)
        {
            var stock = Mapper.Map<ProductStock>(addedDto);
            stock.UpdatedDate = DateTime.Now;
            await DbContext.ProductStocks.AddAsync(stock);
            await DbContext.SaveChangesAsync();
            return new SuccessResult(ProductStockMessagesTR.ProductStockAdded);
        }

        public async Task<IResult> Delete(ProductStockDeleteDTO deletedDto)
        {
            var stock = await DbContext.ProductStocks.SingleOrDefaultAsync(p => p.ProductId == deletedDto.ProductId);
            if (stock == null)
                return new ErrorResult($"{ProductMessagesTR.Product} {BaseConstantsTR.ID} {BaseConstantsTR.NotFound}");

            await Task.Run(() => DbContext.ProductStocks.Remove(stock));
            await DbContext.SaveChangesAsync();
            return new SuccessResult(ProductStockMessagesTR.ProductStockDeleted);
        }

        public async Task<IResult> Update(ProductStockUpdateDTO updatedDto)
        {
            var result = await DbContext.ProductStocks.SingleOrDefaultAsync(b => b.ProductId == updatedDto.ProductId);
            if (result is null)
                return new ErrorResult($"{ProductMessagesTR.Product} {BaseConstantsTR.ID} {BaseConstantsTR.NotFound}");

            var stock = Mapper.Map<ProductStock>(result);
            stock.UnitStock+= result.UnitStock;
            stock.UpdatedDate = DateTime.Now;
            await Task.Run(() => DbContext.ProductStocks.Update(stock));
            await DbContext.SaveChangesAsync();
            return new SuccessResult(ProductStockMessagesTR.ProductStockUpdated);
        }

        public async Task<IDataResult<List<ProductStock>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<ProductStock>> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}