using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.FeatureValues.Rules;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.FeatureValues.Commands.UpdateFeatureValue
{
    public partial class FeatureValueUpdateCommand : IRequest<IResult>
    {
        public int Id { get; set; }
        public int FeatureId { get; set; }
        public string Value { get; set; }

        public class FeatureUpdateCommandHandler : IRequestHandler<FeatureValueUpdateCommand, IResult>
        {
            private readonly IFeatureValueRepository _featureValueRepository;
            private readonly IMapper _mapper;
            private readonly IFeatureValueBusinessRules _featureValueBusinessRules;

            public FeatureUpdateCommandHandler(IFeatureValueRepository featureValueRepository, IMapper mapper, IFeatureValueBusinessRules featureValueBusinessRules)
            {
                _featureValueRepository = featureValueRepository;
                _mapper = mapper;
                _featureValueBusinessRules = featureValueBusinessRules;
            }

            public async Task<IResult> Handle(FeatureValueUpdateCommand request, CancellationToken cancellationToken)
            {
                var nameCheck = await _featureValueBusinessRules.FeatureValueNameExists(request.Value);
                if (!nameCheck.Success)
                    return new ErrorResult(nameCheck.Message);
                var idCheck = await _featureValueBusinessRules.IsIDExists(request.Id);
                if (!idCheck.Success)
                    return new ErrorResult(idCheck.Message);

                var mappedFeatureValue = _mapper.Map<FeatureValue>(idCheck);
                mappedFeatureValue.Status = true;
                mappedFeatureValue.UpdatedDate = DateTime.Now;
                await _featureValueRepository.UpdateAsync(mappedFeatureValue);
                return new SuccessResult("Feature Value Updated");
            }
        }
    }
}