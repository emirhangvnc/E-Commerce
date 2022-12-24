using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Base.Commands;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.Countries.Rules
{
    public class CountryBusinessRules : ManagerBase, ICountryBusinessRules
    {
        ICountryRepository _countryRepository;
        public CountryBusinessRules(IMapper mapper, ICountryRepository countryRepository) : base(mapper)
        {
            _countryRepository = countryRepository;
        }

        public async Task<IDataResult<Country>> IsIDExists(int id)
        {
            var result = await _countryRepository.GetAsync(b => b.Id == id);
            if (result == null)
                return new ErrorDataResult<Country>("Country Not Found");

            return new SuccessDataResult<Country>(result);
        }
    }
}