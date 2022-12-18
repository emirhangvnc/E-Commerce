using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.Features.Rules;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceLayer.Application.Features.Concrete.Features.Commands.UpdateFeature
{
    public partial class FeatureUpdateCommand : IRequest<IResult>
    {
        public int Id { get; set; }
        public string FeatureName { get; set; }

        public class FeatureUpdateCommandHandler : IRequestHandler<FeatureUpdateCommand, IResult>
        {
            private readonly IFeatureRepository _featureRepository;
            private readonly IMapper _mapper;
            private readonly IFeatureBusinessRules _featureBusinessRules;

            public FeatureUpdateCommandHandler(IFeatureRepository featureRepository, IMapper mapper, IFeatureBusinessRules featureBusinessRules)
            {
                _featureRepository = featureRepository;
                _mapper = mapper;
                _featureBusinessRules = featureBusinessRules;
            }

            public async Task<IResult> Handle(FeatureUpdateCommand request, CancellationToken cancellationToken)
            {
                var nameCheck = await _featureBusinessRules.FeatureNameExists(request.FeatureName);
                if (!nameCheck.Success)
                    return new ErrorResult(nameCheck.Message);
                var idCheck = await _featureBusinessRules.IsIDExists(request.Id);
                if (!idCheck.Success)
                    return new ErrorResult(idCheck.Message);

                var mappedFeature = _mapper.Map<Feature>(idCheck);
                mappedFeature.Status = true;
                await _featureRepository.UpdateAsync(mappedFeature);
                return new SuccessResult("Feature Updated");
            }
        }
    }
}