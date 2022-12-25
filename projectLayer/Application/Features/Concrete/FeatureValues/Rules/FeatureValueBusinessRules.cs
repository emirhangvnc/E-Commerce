using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Base.Commands;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.FeatureValues.Rules
{
    public class FeatureValueBusinessRules : ManagerBase, IFeatureValueBusinessRules
    {
        IFeatureValueRepository _featureValueRepository;
        public FeatureValueBusinessRules(IMapper mapper, IFeatureValueRepository featureValueRepository) : base(mapper)
        {
            _featureValueRepository = featureValueRepository;
        }

        public async Task<IResult> FeatureValueNameExists(string name)
        {
            var result = await _featureValueRepository.GetAsync(f => f.Value == name);
            if (result != null && result.Status==true)
                return new ErrorResult($"Feature Value Name {result.Id} Used by ID Number");
            return new SuccessResult();
        }

        public async Task<IDataResult<FeatureValue>> IsIDExists(int id)
        {
            var result = await _featureValueRepository.GetAsync(c => c.Id == id);
            if (result == null)
                return new ErrorDataResult<FeatureValue>("Feature Value Not Found");

            return new SuccessDataResult<FeatureValue>(result);
        }
    }
}