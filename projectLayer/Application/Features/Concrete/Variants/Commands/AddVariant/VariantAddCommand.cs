using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.Variants.Rules;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.Variants.Commands.AddVariant
{
    public partial class VariantAddCommand : IRequest<IResult>
    {
        public string VariantName { get; set; }

        public class VariantAddCommandHandler : IRequestHandler<VariantAddCommand, IResult>
        {
            private readonly IVariantRepository _variantRepository;
            private readonly IMapper _mapper;
            private readonly IVariantBusinessRules _variantBusinessRules;

            public VariantAddCommandHandler(IVariantRepository variantRepository, IMapper mapper, IVariantBusinessRules variantBusinessRules)
            {
                _variantRepository = variantRepository;
                _mapper = mapper;
                _variantBusinessRules = variantBusinessRules;
            }

            public async Task<IResult> Handle(VariantAddCommand request, CancellationToken cancellationToken)
            {
                var result = await _variantBusinessRules.VariantNameExists(request.VariantName);
                if (!result.Success)
                    return new ErrorResult(result.Message);

                var mappedVariant = _mapper.Map<Variant>(request);
                mappedVariant.Status = true;
                mappedVariant.CreatedDate = DateTime.Now;
                mappedVariant.UpdatedDate = DateTime.Now;
                await _variantRepository.AddAsync(mappedVariant);
                return new SuccessResult("Variant Added");
            }
        }
    }
}