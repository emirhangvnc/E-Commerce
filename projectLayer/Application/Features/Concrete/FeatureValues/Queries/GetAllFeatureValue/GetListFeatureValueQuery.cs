using AutoMapper;
using Core.Application.Requests;
using Core.Persistence.Paging;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.FeatureValues.Model;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.FeatureValues.Queries.GetAllFeatureValue
{
    public class GetListFeatureValueQuery : IRequest<IDataResult<FeatureValue>>
    {
        public PageRequest PageRequest { get; set; }
        public class GetListFeatureValueQueryHandler : IRequestHandler<GetListFeatureValueQuery, IDataResult<FeatureValue>>
        {
            private readonly IFeatureValueRepository _featureValueRepository;
            private readonly IMapper _mapper;

            public GetListFeatureValueQueryHandler(IFeatureValueRepository featureValueRepository, IMapper mapper)
            {
                _featureValueRepository = featureValueRepository;
                _mapper = mapper;
            }

            public async Task<IDataResult<FeatureValue>> Handle(GetListFeatureValueQuery request, CancellationToken cancellationToken)
            {
                IPaginate<FeatureValue> featureValue = await _featureValueRepository.GetListAsync(index: request.PageRequest.Page, size: request.PageRequest.PageSize);
                if (featureValue.Items.Count <= 0)
                    return new ErrorDataResult<FeatureValue>("Feature Value Not Found");
                var mappedFeatureValueListModel = _mapper.Map<FeatureValueListModel>(featureValue);

                return new SuccessDataResult<FeatureValue>(mappedFeatureValueListModel, "Feature Values Listed");
            }
        }
    }
}