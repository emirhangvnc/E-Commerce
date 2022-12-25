using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.Cities.Rules;
using eCommerceLayer.Domain.Entities;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.Cities.Queries.GetByIdCity
{
    public class GetByIdCityQuery : IRequest<IDataResult<City>>
    {
        public int Id { get; set; }
        public class GetByIdCityQueryHandler : IRequestHandler<GetByIdCityQuery, IDataResult<City>>
        {
            private readonly IMapper _mapper;
            private readonly ICityBusinessRules _cityBusinessRules;

            public GetByIdCityQueryHandler(IMapper mapper, ICityBusinessRules cityBusinessRules)
            {
                _mapper = mapper;
                _cityBusinessRules = cityBusinessRules;
            }

            public async Task<IDataResult<City>> Handle(GetByIdCityQuery request, CancellationToken cancellationToken)
            {
                var result = await _cityBusinessRules.IsIDExists(request.Id);
                if (!result.Success)
                    return new ErrorDataResult<City>(result.Message);

                return new SuccessDataResult<City>(result.Data, "City Listed");
            }
        }
    }
}