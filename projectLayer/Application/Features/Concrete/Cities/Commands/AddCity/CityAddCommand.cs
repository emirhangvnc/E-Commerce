using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.Cities.Rules;
using eCommerceLayer.Application.Features.Concrete.Countries.Rules;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceLayer.Application.Features.Concrete.Cities.Commands.AddCity
{
    public partial class CityAddCommand : IRequest<IResult>
    {
        public string CityName { get; set; }
        public int CountryId { get; set; }
        public string? CityCode { get; set; }

        public class CityAddCommandHandler : IRequestHandler<CityAddCommand, IResult>
        {
            private readonly ICityRepository _cityRepository;
            private readonly IMapper _mapper;
            private readonly ICityBusinessRules _cityBusinessRules;

            public CityAddCommandHandler(ICityRepository cityRepository, IMapper mapper, ICityBusinessRules cityBusinessRules)
            {
                _cityRepository = cityRepository;
                _mapper = mapper;
                _cityBusinessRules = cityBusinessRules;
            }

            public async Task<IResult> Handle(CityAddCommand request, CancellationToken cancellationToken)
            {
                var mappedCity = _mapper.Map<City>(request);
                mappedCity.Status = true;
                mappedCity.CreatedDate = DateTime.Now;
                mappedCity.UpdatedDate = DateTime.Now;
                await _cityRepository.AddAsync(mappedCity);
                return new SuccessResult("City Added");
            }
        }
    }
}