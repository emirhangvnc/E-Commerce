using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Base.Commands;
using eCommerceLayer.Application.Features.Concrete.ProductStocks.Constants.Languages.TR;
using eCommerceLayer.Application.Features.Concrete.ProductStocks.DTOs;
using eCommerceLayer.Application.Features.Concrete.ProductStocks.Rules;
using eCommerceLayer.Domain.Entities;
using eCommerceLayer.Persistence.Concrete.Contexts;

namespace eCommerceLayer.Application.Features.Concrete.ProductStocks.Queries.GetByProductId
{
    public class GetByProductIdQuery : ManagerBase, IGetByProductIdQuery
    {
        IProductStockBusinessRules _productStockBusinessRules;
        public GetByProductIdQuery(IMapper mapper, BaseDbContext context, IProductStockBusinessRules productStockBusinessRules) : base(mapper, context)
        {
            _productStockBusinessRules = productStockBusinessRules;
        }

        public async Task<IDataResult<ProductStock>> GetById(ProductStockGetByIdDto productStockGetByIdDto)
        {
            var result = await _productStockBusinessRules.IsIDExists(productStockGetByIdDto.Id);

            if (result.Message != null)
                return new ErrorDataResult<ProductStock>(result.Message);

            return new SuccessDataResult<ProductStock>(result.Data, ProductStockMessagesTR.ProductStockListed);
        }
    }
}
