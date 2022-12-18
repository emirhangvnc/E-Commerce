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

namespace eCommerceLayer.Application.Features.Concrete.Features.Commands.DeleteFeature
{
    public partial class FeatureDeleteCommand : IRequest<IResult>
    {
        public int Id { get; set; }

        public class FeatureDeleteCommandHandler : IRequestHandler<FeatureDeleteCommand, IResult>
        {
            private readonly IFeatureRepository _featureRepository;
            private readonly IMapper _mapper;
            private readonly IFeatureBusinessRules _featureBusinessRules;

            public FeatureDeleteCommandHandler(IFeatureRepository featureRepository, IMapper mapper, IFeatureBusinessRules featureBusinessRules)
            {
                _featureRepository = featureRepository;
                _mapper = mapper;
                _featureBusinessRules = featureBusinessRules;
            }

            public async Task<IResult> Handle(FeatureDeleteCommand request, CancellationToken cancellationToken)
            {
                var result = await _featureBusinessRules.IsIDExists(request.Id);
                if (!result.Success)
                    return new ErrorResult(result.Message);

                result.Data.Status = false;
                return new SuccessResult("Feature Deleted");
            }
        }
    }
}