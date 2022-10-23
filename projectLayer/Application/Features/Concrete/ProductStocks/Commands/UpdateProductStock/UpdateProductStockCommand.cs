using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Base.Commands;
using eCommerceLayer.Application.Features.Base.Constants.Languages.TR.Base;
using eCommerceLayer.Application.Features.Concrete.Products.Constants.Languages.TR;
using eCommerceLayer.Application.Features.Concrete.ProductStocks.Constants.Languages.TR;
using eCommerceLayer.Application.Features.Concrete.ProductStocks.DTOs;
using eCommerceLayer.Application.Features.Concrete.ProductStocks.Rules;
using eCommerceLayer.Domain.Entities;
using eCommerceLayer.Persistence.Concrete.Contexts;
using static Core.Application.Pipelines.Validation.ValidationTool;

namespace eCommerceLayer.Application.Features.Concrete.ProductStocks.Commands.UpdateProductStock
{
    public class UpdateProductStockCommand : ManagerBase, IUpdateProductStockService
    {
        IProductStockBusinessRules _productStockBusinessRules;
        public UpdateProductStockCommand(BaseDbContext context, IMapper mapper, IProductStockBusinessRules productStockBusinessRules) : base(mapper, context)
        {
            _productStockBusinessRules = productStockBusinessRules;
        }

        [ValidationAspect(typeof(UpdateProductStockDTOValidator))]
        public async Task<IResult> Update(ProductStockUpdateDTO updateDto)
        {
            var result = _productStockBusinessRules.IsIDExists(updateDto.ProductId);
            if (result is null)
                return new ErrorResult($"{ProductMessagesTR.Product} {BaseConstantsTR.ID} {BaseConstantsTR.NotFound}");

            var stock = Mapper.Map<ProductStock>(result);
            stock.UpdatedDate = DateTime.Now;
            await Task.Run(() => DbContext.ProductStocks.Update(stock));
            await DbContext.SaveChangesAsync();
            return new SuccessResult(ProductStockMessagesTR.ProductStockUpdated);
        }
    }
}