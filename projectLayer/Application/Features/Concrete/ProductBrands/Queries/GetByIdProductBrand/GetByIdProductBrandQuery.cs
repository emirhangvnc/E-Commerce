using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.ProductBrands.Rules;
using eCommerceLayer.Application.Features.Concrete.ProductCategories.Rules;
using eCommerceLayer.Domain.Entities;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.ProductBrands.Queries.GetByIdProductBrand
{
    public class GetByIdProductBrandQuery : IRequest<IDataResult<ProductBrand>>
    {
        public int Id { get; set; }
        public class GetByIdProductBrandQueryHandler : IRequestHandler<GetByIdProductBrandQuery, IDataResult<ProductBrand>>
        {
            private readonly IProductBrandBusinessRules _productBrandBusinessRules;

            public GetByIdProductBrandQueryHandler(IProductBrandBusinessRules productBrandBusinessRules)
            {
                _productBrandBusinessRules = productBrandBusinessRules;
            }

            public async Task<IDataResult<ProductBrand>> Handle(GetByIdProductBrandQuery request, CancellationToken cancellationToken)
            {
                var result = await _productBrandBusinessRules.IsIDExists(request.Id);
                if (!result.Success)
                    return new ErrorDataResult<ProductBrand>(result.Message);

                return new SuccessDataResult<ProductBrand>(result.Data, "Product Brand Listed");
            }
        }
    }
}