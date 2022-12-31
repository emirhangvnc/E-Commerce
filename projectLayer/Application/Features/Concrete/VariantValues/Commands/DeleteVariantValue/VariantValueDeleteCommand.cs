using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.VariantValues.Rules;
using eCommerceLayer.Application.Features.Services.Repositories;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.VariantValues.Commands.DeleteVariantValue
{
    public partial class VariantValueDeleteCommand : IRequest<IResult>
    {
        public int Id { get; set; }

        public class VariantValueDeleteCommandHandler : IRequestHandler<VariantValueDeleteCommand, IResult>
        {
            private readonly IVariantValueRepository _variantValueRepository;
            private readonly IMapper _mapper;
            private readonly IVariantValueBusinessRules _variantValueBusinessRules;

            public VariantValueDeleteCommandHandler(IVariantValueRepository variantValueRepository, IMapper mapper, IVariantValueBusinessRules variantValueBusinessRules)
            {
                _variantValueRepository = variantValueRepository;
                _mapper = mapper;
                _variantValueBusinessRules = variantValueBusinessRules;
            }

            public async Task<IResult> Handle(VariantValueDeleteCommand request, CancellationToken cancellationToken)
            {
                var result = await _variantValueBusinessRules.IsIDExists(request.Id);
                if (!result.Success)
                    return new ErrorResult(result.Message);

                result.Data.Status = false;
                result.Data.UpdatedDate = DateTime.Now;
                return new SuccessResult("Variant Value Deleted");
            }
        }
    }
}