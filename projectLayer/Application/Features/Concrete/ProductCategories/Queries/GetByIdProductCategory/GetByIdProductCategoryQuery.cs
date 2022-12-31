using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.ProductCategories.Rules;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.ProductCategories.Queries.GetByIdProductCategory
{
    public class GetByIdProductCategoryQuery : IRequest<IDataResult<ProductCategory>>
    {
        public int Id { get; set; }
        public class GetByIdProductCategoryQueryHandler : IRequestHandler<GetByIdProductCategoryQuery, IDataResult<ProductCategory>>
        {
            private readonly IProductCategoryBusinessRules _productCategoryBusinessRules;

            public GetByIdProductCategoryQueryHandler(IProductCategoryBusinessRules productCategoryBusinessRules)
            {
                _productCategoryBusinessRules = productCategoryBusinessRules;
            }

            public async Task<IDataResult<ProductCategory>> Handle(GetByIdProductCategoryQuery request, CancellationToken cancellationToken)
            {
                var result = await _productCategoryBusinessRules.IsIDExists(request.Id);
                if (!result.Success)
                    return new ErrorDataResult<ProductCategory>(result.Message);

                return new SuccessDataResult<ProductCategory>(result.Data, "Product Category Listed");
            }
        }
    }
}