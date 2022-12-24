using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.Features.Rules;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.Features.Queries.GetByIdFeature
{
    public class GetByIdFeatureQuery : IRequest<IDataResult<Feature>>
    {
        public int Id { get; set; }
        public class GetByIdFeatureQueryHandler : IRequestHandler<GetByIdFeatureQuery, IDataResult<Feature>>
        {
            private readonly IFeatureRepository _featureRepository;
            private readonly IMapper _mapper;
            private readonly IFeatureBusinessRules _featureBusinessRules;

            public GetByIdFeatureQueryHandler(IFeatureRepository featureRepository, IMapper mapper, IFeatureBusinessRules featureBusinessRules)
            {
                _featureRepository = featureRepository;
                _mapper = mapper;
                _featureBusinessRules = featureBusinessRules;
            }

            public async Task<IDataResult<Feature>> Handle(GetByIdFeatureQuery request, CancellationToken cancellationToken)
            {
                var result = await _featureBusinessRules.IsIDExists(request.Id);
                if (!result.Success)
                    return new ErrorDataResult<Feature>(result.Message);

                return new SuccessDataResult<Feature>(result.Data, "Feature Listed");
            }
        }
    }
}