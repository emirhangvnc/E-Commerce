using AutoMapper;
using Core.Security.Results;
using Microsoft.EntityFrameworkCore;
using projectLayer.Application.Features.Base.Constants.Languages.TR.Base;
using projectLayer.Application.Features.Base.Rules;
using projectLayer.Application.Features.Brands.Constants.Languages.TR;
using projectLayer.Application.Features.Brands.DTOs;
using projectLayer.Application.Features.Brands.Validations.TR;
using projectLayer.Application.Features.Categories.Validations.TR;
using projectLayer.Application.Services.Abstract;
using projectLayer.Domain.Entities;
using projectLayer.Persistence.Contexts;
using Core.Application.Pipelines.Validation;
using static Core.Application.Pipelines.Validation.ValidationTool;
using Core.CrossCuttingConcers.Exceptions;
using Core.Persistence.Paging;
using projectLayer.Persistence.Services.Repositories;

namespace projectLayer.Application.Features.Brands.Rules
{
    public class BrandBusinessRules
    {
        private readonly IBrandRepository _brandRepository;

        public BrandBusinessRules(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task BrandNameCanNotBeDuplicatedWhenInserted(string name)
        {
            IPaginate<Brand> result = await _brandRepository.GetListAsync(b => b.BrandName == name);
            if (result.Items.Any()) throw new BusinessException("Brand name exists.");
        }

        public void BrandShouldExistWhenRequested(Brand brand)
        {
            if (brand == null) throw new BusinessException("Requested brand does not exist");
        }
    }
}