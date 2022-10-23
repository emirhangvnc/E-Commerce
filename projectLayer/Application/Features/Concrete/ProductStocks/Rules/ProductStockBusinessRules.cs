using eCommerceLayer.Application.Features.Concrete.ProductStocks.Constants.Languages.TR;
using eCommerceLayer.Domain.Entities;
using Core.CrossCuttingConcers.Exceptions;
using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Base.Commands;
using eCommerceLayer.Persistence.Concrete.Contexts;
using Microsoft.EntityFrameworkCore;
using eCommerceLayer.Application.Features.Concrete.Products.Constants.Languages.TR;

namespace eCommerceLayer.Application.Features.Concrete.ProductStocks.Rules
{
    public class ProductStockBusinessRules : ManagerBase, IProductStockBusinessRules
    {
        public ProductStockBusinessRules(IMapper mapper, BaseDbContext context) : base(mapper, context)
        {
        }

        public async Task<IDataResult<ProductStock>> IsIDExists(int id)
        {
            var result = await DbContext.Products.SingleOrDefaultAsync(p => p.Id == id);
            if (result == null)
                return new ErrorDataResult<ProductStock>(ProductMessagesTR.ProductNotFound);
            var stock = await DbContext.ProductStocks.SingleOrDefaultAsync(p => p.Id == result.Id);    

            return new SuccessDataResult<ProductStock>(stock);
        }
    }
}