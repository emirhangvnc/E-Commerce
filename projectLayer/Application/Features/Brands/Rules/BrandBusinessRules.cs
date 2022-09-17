using AutoMapper;
using Core.Security.Results;
using Microsoft.EntityFrameworkCore;
using eCommerceLayer.Application.Features.Base.Constants.Languages.TR.Base;
using eCommerceLayer.Application.Features.Base.Rules;
using eCommerceLayer.Application.Features.Brands.Constants.Languages.TR;
using eCommerceLayer.Application.Features.Brands.DTOs;
using eCommerceLayer.Application.Features.Brands.Validations.TR;
using eCommerceLayer.Application.Features.Categories.Validations.TR;
using eCommerceLayer.Application.Services.Abstract;
using eCommerceLayer.Domain.Entities;
using eCommerceLayer.Persistence.Contexts;
using Core.Application.Pipelines.Validation;
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