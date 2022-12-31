using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.Variants.Rules;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.Variants.Commands.UpdateVariant
{
    public partial class VariantUpdateCommand : IRequest<IResult>
    {
        public int Id { get; set; }
        public string VariantName { get; set; }

        public class VariantUpdateCommandHandler : IRequestHandler<VariantUpdateCommand, IResult>
        {
            private readonly IVariantRepository _variantRepository;
            private readonly IMapper _mapper;
            private readonly IVariantBusinessRules _variantBusinessRules;

            public VariantUpdateCommandHandler(IVariantRepository variantRepository, IMapper mapper, IVariantBusinessRules variantBusinessRules)
            {
                _variantRepository = variantRepository;
                _mapper = mapper;
                _variantBusinessRules = variantBusinessRules;
            }

            public async Task<IResult> Handle(VariantUpdateCommand request, CancellationToken cancellationToken)
            {
                var nameCheck = await _variantBusinessRules.VariantNameExists(request.VariantName);
                if (!nameCheck.Success)
                    return new ErrorResult(nameCheck.Message);
                var idCheck = await _variantBusinessRules.IsIDExists(request.Id);
                if (!idCheck.Success)
                    return new ErrorResult(idCheck.Message);

                var mappedVariant = _mapper.Map<Variant>(idCheck);
                mappedVariant.Status = true;
                mappedVariant.UpdatedDate = DateTime.Now;
                await _variantRepository.UpdateAsync(mappedVariant);
                return new SuccessResult("Variant Updated");
            }
        }
    }
}