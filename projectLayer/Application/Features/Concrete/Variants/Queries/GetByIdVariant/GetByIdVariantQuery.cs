using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.Variants.Rules;
using eCommerceLayer.Domain.Entities;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.Variants.Queries.GetByIdVariant
{
    public class GetByIdVariantQuery : IRequest<IDataResult<Variant>>
    {
        public int Id { get; set; }
        public class GetByIdVariantQueryHandler : IRequestHandler<GetByIdVariantQuery, IDataResult<Variant>>
        {
            private readonly IVariantBusinessRules _variantBusinessRules;

            public GetByIdVariantQueryHandler(IVariantBusinessRules variantBusinessRules)
            {
                _variantBusinessRules = variantBusinessRules;
            }

            public async Task<IDataResult<Variant>> Handle(GetByIdVariantQuery request, CancellationToken cancellationToken)
            {
                var result = await _variantBusinessRules.IsIDExists(request.Id);
                if (!result.Success)
                    return new ErrorDataResult<Variant>(result.Message);

                return new SuccessDataResult<Variant>(result.Data, "Variant Listed");
            }
        }
    }
}