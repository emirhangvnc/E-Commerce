using AutoMapper;
using eCommerceLayer.Domain.Entities;
using eCommerceLayer.Persistence.Concrete.Contexts;
using static Core.Application.Pipelines.Validation.ValidationTool;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.ProductStocks.Constants.Languages.TR;
using eCommerceLayer.Application.Features.Concrete.ProductStocks.Rules;
using eCommerceLayer.Application.Features.Base.Commands;
using eCommerceLayer.Application.Features.Concrete.ProductStocks.DTOs;
using eCommerceLayer.Application.Features.Concrete.ProductStocks.Commands.AddProductStock;

namespace eCommerceLayer.Application.Features.Concrete.ProductStocks.Commands.CreateProductStock
{
    public class AddProductStockCommand:ManagerBase, IAddProductStockService
    {
        IProductStockBusinessRules _productStockBusinessRules;
        public AddProductStockCommand(IMapper mapper, BaseDbContext context, IProductStockBusinessRules productStockBusinessRules) : base(mapper, context)
        {
            _productStockBusinessRules = productStockBusinessRules;
        }

        [ValidationAspect(typeof(AddProductStockDTOValidator))]
        public async Task<IResult> Add(ProductStockAddDTO addedDto)
        {
            var stock = Mapper.Map<ProductStock>(addedDto);
            stock.UpdatedDate = DateTime.Now;
            await DbContext.ProductStocks.AddAsync(stock);
            await DbContext.SaveChangesAsync();
            return new SuccessResult(ProductStockMessagesTR.ProductStockAdded);
        }
    }
}