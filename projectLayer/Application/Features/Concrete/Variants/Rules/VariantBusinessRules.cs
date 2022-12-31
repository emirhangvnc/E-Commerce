using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Base.Commands;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.Variants.Rules
{
    public class VariantBusinessRules : ManagerBase, IVariantBusinessRules
    {
        IVariantRepository _variantRepository;
        public VariantBusinessRules(IMapper mapper, IVariantRepository variantRepository) : base(mapper)
        {
            _variantRepository = variantRepository;
        }

        public async Task<IResult> VariantNameExists(string name)
        {
            var result = await _variantRepository.GetAsync(v => v.VariantName == name);
            if (result != null && result.Status == true)
                return new ErrorResult($"Variant Name {result.Id} Used by ID Number");
            return new SuccessResult();
        }

        public async Task<IDataResult<Variant>> IsIDExists(int id)
        {
            var result = await _variantRepository.GetAsync(b => b.Id == id);
            if (result == null)
                return new ErrorDataResult<Variant>("Variant Not Found");

            return new SuccessDataResult<Variant>(result);
        }
    }
}