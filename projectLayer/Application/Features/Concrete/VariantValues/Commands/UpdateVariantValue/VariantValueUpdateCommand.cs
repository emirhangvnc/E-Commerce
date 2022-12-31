using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.VariantValues.Rules;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.VariantValues.Commands.UpdateVariantValue
{
    public partial class VariantValueUpdateCommand : IRequest<IResult>
    {
        public int Id { get; set; }
        public int VariantId { get; set; }
        public string Value { get; set; }

        public class VariantUpdateCommandHandler : IRequestHandler<VariantValueUpdateCommand, IResult>
        {
            private readonly IVariantValueRepository _variantValueRepository;
            private readonly IMapper _mapper;
            private readonly IVariantValueBusinessRules _variantValueBusinessRules;

            public VariantUpdateCommandHandler(IVariantValueRepository variantValueRepository, IMapper mapper, IVariantValueBusinessRules variantValueBusinessRules)
            {
                _variantValueRepository = variantValueRepository;
                _mapper = mapper;
                _variantValueBusinessRules = variantValueBusinessRules;
            }

            public async Task<IResult> Handle(VariantValueUpdateCommand request, CancellationToken cancellationToken)
            {
                var nameCheck = await _variantValueBusinessRules.VariantValueNameExists(request.Value);
                if (!nameCheck.Success)
                    return new ErrorResult(nameCheck.Message);
                var idCheck = await _variantValueBusinessRules.IsIDExists(request.Id);
                if (!idCheck.Success)
                    return new ErrorResult(idCheck.Message);

                var mappedVariantValue = _mapper.Map<VariantValue>(idCheck);
                mappedVariantValue.Status = true;
                mappedVariantValue.UpdatedDate = DateTime.Now;
                await _variantValueRepository.UpdateAsync(mappedVariantValue);
                return new SuccessResult("Variant Value Updated");
            }
        }
    }
}