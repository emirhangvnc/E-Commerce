using eCommerceLayer.Application.Features.Brands.Constants.Languages.TR;
using eCommerceLayer.Domain.Entities;
using Core.CrossCuttingConcers.Exceptions;
using Core.Persistence.Paging;
using eCommerceLayer.Persistence.Services.Repositories;

namespace eCommerceLayer.Application.Features.Brands.Rules
{
    public class BrandBusinessRules
    {
        private readonly IBrandRepository _brandRepository;

        public BrandBusinessRules(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task BrandNameExists(string name)
        {
            IPaginate<Brand> result = await _brandRepository.GetListAsync(b => b.BrandName == name);
            if (result.Items.Any()) throw new BusinessException($"{BrandMessagesTR.BrandNameExists}");
        }

        public void BrandShouldExistWhenRequested(Brand brand)
        {
            if (brand == null) throw new BusinessException("Requested brand does not exist");
        }
    }
}