using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.FeatureValues.Rules;
using eCommerceLayer.Application.Features.Services.Repositories;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.FeatureValues.Commands.DeleteFeatureValue
{
    public partial class FeatureValueDeleteCommand : IRequest<IResult>
    {
        public int Id { get; set; }

        public class FeatureValueDeleteCommandHandler : IRequestHandler<FeatureValueDeleteCommand, IResult>
        {
            private readonly IFeatureValueRepository _featureValueRepository;
            private readonly IMapper _mapper;
            private readonly IFeatureValueBusinessRules _featureValueBusinessRules;

            public FeatureValueDeleteCommandHandler(IFeatureValueRepository featureValueRepository, IMapper mapper, IFeatureValueBusinessRules featureValueBusinessRules)
            {
                _featureValueRepository = featureValueRepository;
                _mapper = mapper;
                _featureValueBusinessRules = featureValueBusinessRules;
            }

            public async Task<IResult> Handle(FeatureValueDeleteCommand request, CancellationToken cancellationToken)
            {
                var result = await _featureValueBusinessRules.IsIDExists(request.Id);
                if (!result.Success)
                    return new ErrorResult(result.Message);

                result.Data.Status = false;
                result.Data.UpdatedDate = DateTime.Now;
                return new SuccessResult("Feature Value Deleted");
            }
        }
    }
}