using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.Countries.Rules;
using eCommerceLayer.Domain.Entities;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.Countries.Queries.GetByIdCountry
{
    public class GetByIdCountryQuery : IRequest<IDataResult<Country>>
    {
        public int Id { get; set; }
        public class GetByIdCountryQueryHandler : IRequestHandler<GetByIdCountryQuery, IDataResult<Country>>
        {
            private readonly IMapper _mapper;
            private readonly ICountryBusinessRules _countryBusinessRules;

            public GetByIdCountryQueryHandler(IMapper mapper, ICountryBusinessRules countryBusinessRules)
            {
                _mapper = mapper;
                _countryBusinessRules = countryBusinessRules;
            }

            public async Task<IDataResult<Country>> Handle(GetByIdCountryQuery request, CancellationToken cancellationToken)
            {
                var result = await _countryBusinessRules.IsIDExists(request.Id);
                if (!result.Success)
                    return new ErrorDataResult<Country>(result.Message);

                return new SuccessDataResult<Country>(result.Data, "Country Listed");
            }
        }
    }
}