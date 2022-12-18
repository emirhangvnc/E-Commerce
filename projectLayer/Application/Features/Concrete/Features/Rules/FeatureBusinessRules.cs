using AutoMapper;
using Core.Utilities.Results;
using eCommerceLayer.Application.Features.Base.Commands;
using eCommerceLayer.Application.Features.Services.Repositories;
using eCommerceLayer.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace eCommerceLayer.Application.Features.Concrete.Features.Rules
{
    public class FeatureBusinessRules : ManagerBase, IFeatureBusinessRules
    {
        IFeatureRepository _featureRepository;
        public FeatureBusinessRules(IMapper mapper, IFeatureRepository featureRepository) : base(mapper)
        {
            _featureRepository= featureRepository;
        }

        public async Task<IResult> FeatureNameExists(string name)
        {
            var result = await _featureRepository.GetAsync(f => f.FeatureName == name);
            if (result != null && result.Status==true)
                return new ErrorResult($"Feature Name {result.Id} Used by ID Number");
            return new SuccessResult();
        }

        public async Task<IDataResult<Feature>> IsIDExists(int id)
        {
            var result = await _featureRepository.GetAsync(c => c.Id == id);
            if (result == null)
                return new ErrorDataResult<Feature>("Feature Not Found");

            return new SuccessDataResult<Feature>(result);
        }
    }
}