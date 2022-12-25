using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Base.Commands;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.Cities.Rules
{
    public class CityBusinessRules : ManagerBase, ICityBusinessRules
    {
        ICityRepository _cityRepository;
        public CityBusinessRules(IMapper mapper, ICityRepository cityRepository) : base(mapper)
        {
            _cityRepository = cityRepository;
        }

        public async Task<IDataResult<City>> IsIDExists(int id)
        {
            var result = await _cityRepository.GetAsync(b => b.Id == id);
            if (result == null)
                return new ErrorDataResult<City>("City Not Found");

            return new SuccessDataResult<City>(result);
        }
    }
}