using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.ProductVariants.Rules;
using eCommerceLayer.Domain.Entities;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.ProductVariants.Queries.GetByIdProductVariant
{
    public class GetByIdProductVariantQuery : IRequest<IDataResult<ProductVariant>>
    {
        public int Id { get; set; }
        public class GetByIdProductVariantQueryHandler : IRequestHandler<GetByIdProductVariantQuery, IDataResult<ProductVariant>>
        {
            private readonly IProductVariantBusinessRules _productVariantBusinessRules;

            public GetByIdProductVariantQueryHandler(IProductVariantBusinessRules productVariantBusinessRules)
            {
                _productVariantBusinessRules = productVariantBusinessRules;
            }

            public async Task<IDataResult<ProductVariant>> Handle(GetByIdProductVariantQuery request, CancellationToken cancellationToken)
            {
                var result = await _productVariantBusinessRules.IsIDExists(request.Id);
                if (!result.Success)
                    return new ErrorDataResult<ProductVariant>(result.Message);

                return new SuccessDataResult<ProductVariant>(result.Data, "Product Variant Listed");
            }
        }
    }
}