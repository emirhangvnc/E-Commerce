using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Base.Commands;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.VariantValues.Rules
{
    public class VariantValueBusinessRules : ManagerBase, IVariantValueBusinessRules
    {
        IVariantValueRepository _variantValueRepository;
        public VariantValueBusinessRules(IMapper mapper, IVariantValueRepository variantValueRepository) : base(mapper)
        {
            _variantValueRepository = variantValueRepository;
        }

        public async Task<IResult> VariantValueNameExists(string name)
        {
            var result = await _variantValueRepository.GetAsync(f => f.Value == name);
            if (result != null && result.Status == true)
                return new ErrorResult($"Variant Value Name {result.Id} Used by ID Number");
            return new SuccessResult();
        }

        public async Task<IDataResult<VariantValue>> IsIDExists(int id)
        {
            var result = await _variantValueRepository.GetAsync(c => c.Id == id);
            if (result == null)
                return new ErrorDataResult<VariantValue>("Variant Value Not Found");

            return new SuccessDataResult<VariantValue>(result);
        }
    }
}