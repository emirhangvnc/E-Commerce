using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Base.Commands;
using eCommerceLayer.Application.Features.Concrete.Products.Constants.Languages.TR;
using eCommerceLayer.Application.Features.Concrete.Products.DTOs;
using eCommerceLayer.Application.Features.Concrete.Products.Rules;
using eCommerceLayer.Domain.Entities;
using eCommerceLayer.Persistence.Concrete.Contexts;

namespace eCommerceLayer.Application.Features.Concrete.Products.Queries.GetByProductId
{
    public class GetByProductIdQuery : ManagerBase, IGetByProductIdQuery
    {
        IProductBusinessRules _productBusinessRules;
        public GetByProductIdQuery(IMapper mapper, BaseDbContext context, IProductBusinessRules productBusinessRules) : base(mapper, context)
        {
            _productBusinessRules = productBusinessRules;
        }

        public async Task<IDataResult<Product>> GetById(ProductGetByIdDto productStockGetByIdDto)
        {
            var result = await _productBusinessRules.IsIDExists(productStockGetByIdDto.Id);
            if (result.Message != null)
                return new ErrorDataResult<Product>(result.Message);

            return new SuccessDataResult<Product>(result.Data, ProductMessagesTR.ProductListed);
        }
    }
}
