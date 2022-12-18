using AutoMapper;
using Core.Application.Requests;
using Core.Persistence.Paging;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.Features.DTOs;
using eCommerceLayer.Application.Features.Concrete.Features.Model;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.Features.Queries.GetAllFeatures
{
    public class GetListFeatureQuery : IRequest<IDataResult<Feature>>
    {
        public PageRequest PageRequest { get; set; }
        public class GetListFeatureQueryHandler : IRequestHandler<GetListFeatureQuery, IDataResult<Feature>>
        {
            private readonly IFeatureRepository _featureRepository;
            private readonly IMapper _mapper;

            public GetListFeatureQueryHandler(IFeatureRepository featureRepository, IMapper mapper)
            {
                _featureRepository = featureRepository;
                _mapper = mapper;
            }

            public async Task<IDataResult<Feature>> Handle(GetListFeatureQuery request, CancellationToken cancellationToken)
            {
                IPaginate<Feature> Feature = await _featureRepository.GetListAsync(index: request.PageRequest.Page, size: request.PageRequest.PageSize);
                if (Feature.Items.Count <= 0)
                    return new ErrorDataResult<Feature>("Feature Not Found");
                var mappedFeatureListModel = _mapper.Map<FeatureListModel>(Feature);

                return new SuccessDataResult<Feature>(mappedFeatureListModel,"Features Listed");
            }
        }
    }
}