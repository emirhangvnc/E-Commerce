using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Base.Commands;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.Brands.Rules
{
    public class BrandBusinessRules : ManagerBase, IBrandBusinessRules
    {
        IBrandRepository _brandRepository;
        public BrandBusinessRules(IMapper mapper, IBrandRepository brandRepository) : base(mapper)
        {
            _brandRepository = brandRepository;
        }

        public async Task<IResult> BrandNameExists(string name)
        {
            var result = await _brandRepository.GetAsync(b => b.BrandName == name);
            if (result != null && result.Status==true)
                return new ErrorResult($"Brand Name {result.Id} Used by ID Number");
            return new SuccessResult();
        }

        public async Task<IDataResult<Brand>> IsIDExists(int id)
        {
            var result = await _brandRepository.GetAsync(b => b.Id == id);
            if (result == null)
                return new ErrorDataResult<Brand>("Brand Not Found");

            return new SuccessDataResult<Brand>(result);
        }
    }
}