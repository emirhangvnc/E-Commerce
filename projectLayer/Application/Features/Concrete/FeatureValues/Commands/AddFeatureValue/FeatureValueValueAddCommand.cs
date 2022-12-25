using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.FeatureValues.Rules;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.FeatureValues.Commands.AddFeatureValue
{
    public partial class FeatureValueAddCommand : IRequest<IResult>
    {
        public int FeatureId { get; set; }
        public string Value { get; set; }

        public class FeatureValueAddCommandHandler : IRequestHandler<FeatureValueAddCommand, IResult>
        {
            private readonly IFeatureValueRepository _featureValueRepository;
            private readonly IMapper _mapper;
            private readonly IFeatureValueBusinessRules _featureValueBusinessRules;

            public FeatureValueAddCommandHandler(IFeatureValueRepository featureValueRepository, IMapper mapper, IFeatureValueBusinessRules featureValueBusinessRules)
            {
                _featureValueRepository = featureValueRepository;
                _mapper = mapper;
                _featureValueBusinessRules = featureValueBusinessRules;
            }

            public async Task<IResult> Handle(FeatureValueAddCommand request, CancellationToken cancellationToken)
            {
                var result= await _featureValueBusinessRules.FeatureValueNameExists(request.Value);
                if (!result.Success)
                    return new ErrorResult(result.Message);

                var mappedFeatureValue = _mapper.Map<FeatureValue>(request);
                mappedFeatureValue.Status = true;
                mappedFeatureValue.CreatedDate = DateTime.Now;
                mappedFeatureValue.UpdatedDate = DateTime.Now;
                await _featureValueRepository.AddAsync(mappedFeatureValue);
                return new SuccessResult("Feature Value Added");
            }
        }
    }
}