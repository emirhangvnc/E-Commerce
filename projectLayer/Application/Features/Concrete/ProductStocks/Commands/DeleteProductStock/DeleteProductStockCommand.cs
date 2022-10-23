using AutoMapper;
using eCommerceLayer.Application.Features.Concrete.ProductStocks.DTOs;
using eCommerceLayer.Application.Features.Concrete.ProductStocks.Rules;
using eCommerceLayer.Domain.Entities;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Base.Commands;
using eCommerceLayer.Persistence.Concrete.Contexts;
using static Core.Application.Pipelines.Validation.ValidationTool;
using eCommerceLayer.Application.Features.Concrete.ProductStocks.Constants.Languages.TR;
using eCommerceLayer.Application.Features.Base.Constants.Languages.TR.Base;
using eCommerceLayer.Application.Features.Concrete.Products.Constants.Languages.TR;

namespace eCommerceLayer.Application.Features.Concrete.ProductStocks.Commands.DeleteProductStock
{
    public class DeleteProductStockCommand : ManagerBase, IDeleteProductStockService
    {
        IProductStockBusinessRules _productStockBusinessRules;
        public DeleteProductStockCommand(BaseDbContext context, IMapper mapper, IProductStockBusinessRules productStockBusinessRules) : base(mapper, context)
        {
            _productStockBusinessRules = productStockBusinessRules;
        }

        [ValidationAspect(typeof(DeleteProductStockDTOValidator))]
        public async Task<IResult> Delete(ProductStockDeleteDTO deletedDto)
        {
            var result = _productStockBusinessRules.IsIDExists(deletedDto.ProductId);
            if (result == null)
                return new ErrorResult($"{ProductMessagesTR.Product} {BaseConstantsTR.ID} {BaseConstantsTR.NotFound}");

            var stock = Mapper.Map<ProductStock>(result);
            await Task.Run(() => DbContext.ProductStocks.Remove(stock));
            await DbContext.SaveChangesAsync();
            return new SuccessResult(ProductStockMessagesTR.ProductStockDeleted);
        }
    }
}