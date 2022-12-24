using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.Countries.Rules;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.Countries.Commands.UpdateCountry
{
    public partial class CountryUpdateCommand : IRequest<IResult>
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public string? Alpha2Code { get; set; }
        public string? Alpha3Code { get; set; }
        public int? NumericCode { get; set; }

        public class CountryUpdateCommandHandler : IRequestHandler<CountryUpdateCommand, IResult>
        {
            private readonly ICountryRepository _countryRepository;
            private readonly IMapper _mapper;
            private readonly ICountryBusinessRules _countryBusinessRules;

            public CountryUpdateCommandHandler(ICountryRepository countryRepository, IMapper mapper, ICountryBusinessRules countryBusinessRules)
            {
                _countryRepository = countryRepository;
                _mapper = mapper;
                _countryBusinessRules = countryBusinessRules;
            }

            public async Task<IResult> Handle(CountryUpdateCommand request, CancellationToken cancellationToken)
            {
                var idCheck = await _countryBusinessRules.IsIDExists(request.Id);
                if (!idCheck.Success)
                    return new ErrorResult(idCheck.Message);

                var mappedCountry = _mapper.Map<Country>(idCheck);
                mappedCountry.Status = true;
                mappedCountry.UpdatedDate = DateTime.Now;
                await _countryRepository.UpdateAsync(mappedCountry);
                return new SuccessResult("Country Updated");
            }
        }
    }
}