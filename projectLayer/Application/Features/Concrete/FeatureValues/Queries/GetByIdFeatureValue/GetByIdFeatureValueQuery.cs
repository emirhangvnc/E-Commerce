using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.FeatureValues.Rules;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.FeatureValues.Queries.GetByIdFeatureValue
{
    public class GetByIdFeatureValueQuery : IRequest<IDataResult<FeatureValue>>
    {
        public int Id { get; set; }
        public class GetByIdFeatureValueQueryHandler : IRequestHandler<GetByIdFeatureValueQuery, IDataResult<FeatureValue>>
        {
            private readonly IFeatureValueBusinessRules _featureValueBusinessRules;

            public GetByIdFeatureValueQueryHandler(IFeatureValueBusinessRules featureValueBusinessRules)
            {
                _featureValueBusinessRules = featureValueBusinessRules;
            }

            public async Task<IDataResult<FeatureValue>> Handle(GetByIdFeatureValueQuery request, CancellationToken cancellationToken)
            {
                var result = await _featureValueBusinessRules.IsIDExists(request.Id);
                if (!result.Success)
                    return new ErrorDataResult<FeatureValue>(result.Message);

                return new SuccessDataResult<FeatureValue>(result.Data, "Feature Value Listed");
            }
        }
    }
}