using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.Features.Rules;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.Features.Commands.AddFeature
{
    public partial class FeatureAddCommand : IRequest<IResult>
    {
        public string FeatureName { get; set; }

        public class FeatureAddCommandHandler : IRequestHandler<FeatureAddCommand, IResult>
        {
            private readonly IFeatureRepository _featureRepository;
            private readonly IMapper _mapper;
            private readonly IFeatureBusinessRules _featureBusinessRules;

            public FeatureAddCommandHandler(IFeatureRepository featureRepository, IMapper mapper, IFeatureBusinessRules featureBusinessRules)
            {
                _featureRepository = featureRepository;
                _mapper = mapper;
                _featureBusinessRules = featureBusinessRules;
            }

            public async Task<IResult> Handle(FeatureAddCommand request, CancellationToken cancellationToken)
            {
                var result= await _featureBusinessRules.FeatureNameExists(request.FeatureName);
                if (!result.Success)
                    return new ErrorResult(result.Message);

                var mappedFeature = _mapper.Map<Feature>(request);
                mappedFeature.Status = true;
                mappedFeature.CreatedDate = DateTime.Now;
                await _featureRepository.AddAsync(mappedFeature);
                return new SuccessResult("Feature Added");
            }
        }
    }
}