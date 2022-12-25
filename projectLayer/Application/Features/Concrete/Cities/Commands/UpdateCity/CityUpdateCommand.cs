using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Concrete.Cities.Rules;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using MediatR;

namespace eCommerceLayer.Application.Features.Concrete.Cities.Commands.UpdateCity
{
    public partial class CityUpdateCommand : IRequest<IResult>
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public int CountryId { get; set; }
        public string? CityCode { get; set; }

        public class CountryUpdateCommandHandler : IRequestHandler<CityUpdateCommand, IResult>
        {
            private readonly ICityRepository _cityRepository;
            private readonly IMapper _mapper;
            private readonly ICityBusinessRules _cityBusinessRules;

            public CountryUpdateCommandHandler(ICityRepository cityRepository, IMapper mapper, ICityBusinessRules cityBusinessRules)
            {
                _cityRepository = cityRepository;
                _mapper = mapper;
                _cityBusinessRules = cityBusinessRules;
            }

            public async Task<IResult> Handle(CityUpdateCommand request, CancellationToken cancellationToken)
            {
                var idCheck = await _cityBusinessRules.IsIDExists(request.Id);
                if (!idCheck.Success)
                    return new ErrorResult(idCheck.Message);

                var mappedCity = _mapper.Map<City>(idCheck);
                mappedCity.Status = true;
                mappedCity.UpdatedDate = DateTime.Now;
                await _cityRepository.UpdateAsync(mappedCity);
                return new SuccessResult("City Updated");
            }
        }
    }
}