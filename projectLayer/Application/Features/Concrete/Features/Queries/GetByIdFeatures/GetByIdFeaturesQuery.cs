using AutoMapper;
using Core.Application.Requests;
using Core.Persistence.Paging;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.Features.DTOs;
using eCommerceLayer.Application.Features.Concrete.Features.Rules;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceLayer.Application.Features.Concrete.Features.Queries.GetByIdFeatures
{
    public class GetByIdFeaturesQuery : IRequest<IDataResult<Feature>>
    {
        public int Id { get; set; }
        public class GetByIdFeaturesQueryHandler : IRequestHandler<GetByIdFeaturesQuery, IDataResult<Feature>>
        {
            private readonly IFeatureRepository _featureRepository;
            private readonly IMapper _mapper;
            private readonly IFeatureBusinessRules _featureBusinessRules;

            public GetByIdFeaturesQueryHandler(IFeatureRepository featureRepository, IMapper mapper, IFeatureBusinessRules featureBusinessRules)
            {
                _featureRepository = featureRepository;
                _mapper = mapper;
                _featureBusinessRules = featureBusinessRules;
            }

            public async Task<IDataResult<Feature>> Handle(GetByIdFeaturesQuery request, CancellationToken cancellationToken)
            {
                var result = await _featureBusinessRules.IsIDExists(request.Id);
                if (!result.Success)
                    return new ErrorDataResult<Feature>(result.Message);

                return new SuccessDataResult<Feature>(result.Data, "Feature Listed");
            }
        }
    }
}