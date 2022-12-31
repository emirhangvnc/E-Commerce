using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.VariantValues.Rules;
using eCommerceLayer.Domain.Entities;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.VariantValues.Queries.GetByIdVariantValue
{
    public class GetByIdVariantValueQuery : IRequest<IDataResult<VariantValue>>
    {
        public int Id { get; set; }
        public class GetByIdVariantValueQueryHandler : IRequestHandler<GetByIdVariantValueQuery, IDataResult<VariantValue>>
        {
            private readonly IVariantValueBusinessRules _variantValueBusinessRules;

            public GetByIdVariantValueQueryHandler(IVariantValueBusinessRules variantValueBusinessRules)
            {
                 _variantValueBusinessRules = variantValueBusinessRules;
            }

            public async Task<IDataResult<VariantValue>> Handle(GetByIdVariantValueQuery request, CancellationToken cancellationToken)
            {
                var result = await _variantValueBusinessRules.IsIDExists(request.Id);
                if (!result.Success)
                    return new ErrorDataResult<VariantValue>(result.Message);

                return new SuccessDataResult<VariantValue>(result.Data, "Variant Value Listed");
            }
        }
    }
}