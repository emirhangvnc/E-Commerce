using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.VariantValues.Rules;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.VariantValues.Commands.AddVariantValue
{
    public partial class VariantValueAddCommand : IRequest<IResult>
    {
        public int VariantId { get; set; }
        public string Value { get; set; }

        public class VariantValueAddCommandHandler : IRequestHandler<VariantValueAddCommand, IResult>
        {
            private readonly IVariantValueRepository _variantValueRepository;
            private readonly IMapper _mapper;
            private readonly IVariantValueBusinessRules _variantValueBusinessRules;

            public VariantValueAddCommandHandler(IVariantValueRepository variantValueRepository, IMapper mapper, IVariantValueBusinessRules variantValueBusinessRules)
            {
                _variantValueRepository = variantValueRepository;
                _mapper = mapper;
                _variantValueBusinessRules = variantValueBusinessRules;
            }

            public async Task<IResult> Handle(VariantValueAddCommand request, CancellationToken cancellationToken)
            {
                var result = await _variantValueBusinessRules.VariantValueNameExists(request.Value);
                if (!result.Success)
                    return new ErrorResult(result.Message);

                var mappedVariantValue = _mapper.Map<VariantValue>(request);
                mappedVariantValue.Status = true;
                mappedVariantValue.CreatedDate = DateTime.Now;
                mappedVariantValue.UpdatedDate = DateTime.Now;
                await _variantValueRepository.AddAsync(mappedVariantValue);
                return new SuccessResult("Variant Value Added");
            }
        }
    }
}