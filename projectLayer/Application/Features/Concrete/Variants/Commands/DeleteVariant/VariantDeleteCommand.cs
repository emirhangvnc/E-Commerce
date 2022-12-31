using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.Variants.Rules;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.Variants.Commands.DeleteVariant
{
    public partial class VariantDeleteCommand : IRequest<IResult>
    {
        public int Id { get; set; }

        public class VariantDeleteCommandHandler : IRequestHandler<VariantDeleteCommand, IResult>
        {
            private readonly IVariantBusinessRules _variantBusinessRules;

            public VariantDeleteCommandHandler(IVariantBusinessRules variantBusinessRules)
            {
                _variantBusinessRules = variantBusinessRules;
            }

            public async Task<IResult> Handle(VariantDeleteCommand request, CancellationToken cancellationToken)
            {
                var result = await _variantBusinessRules.IsIDExists(request.Id);
                if (!result.Success)
                    return new ErrorResult(result.Message);

                result.Data.Status = false;
                result.Data.UpdatedDate = DateTime.Now;
                return new SuccessResult("Variant Deleted");
            }
        }
    }
}