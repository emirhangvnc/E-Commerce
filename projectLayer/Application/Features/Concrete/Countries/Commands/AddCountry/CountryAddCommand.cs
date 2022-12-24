using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.Countries.Rules;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.Countries.Commands.AddCountry
{
    public partial class CountryAddCommand : IRequest<IResult>
    {
        public string CountryName { get; set; }
        public string? Alpha2Code { get; set; }
        public string? Alpha3Code { get; set; }
        public int? NumericCode { get; set; }

        public class CountryAddCommandHandler : IRequestHandler<CountryAddCommand, IResult>
        {
            private readonly ICountryRepository _countryRepository;
            private readonly IMapper _mapper;
            private readonly ICountryBusinessRules _countryBusinessRules;

            public CountryAddCommandHandler(ICountryRepository countryRepository, IMapper mapper, ICountryBusinessRules countryBusinessRules)
            {
                _countryRepository = countryRepository;
                _mapper = mapper;
                _countryBusinessRules = countryBusinessRules;
            }

            public async Task<IResult> Handle(CountryAddCommand request, CancellationToken cancellationToken)
            {
                var mappedCountry = _mapper.Map<Country>(request);
                mappedCountry.Status = true;
                mappedCountry.CreatedDate = DateTime.Now;
                mappedCountry.UpdatedDate = DateTime.Now;
                await _countryRepository.AddAsync(mappedCountry);
                return new SuccessResult("Country Added");
            }
        }
    }
}