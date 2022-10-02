﻿using FluentValidation;
using eCommerceLayer.Application.Features.Base.Constants.Languages.TR.Base;
using eCommerceLayer.Application.Features.Base.Constants.Languages.TR.General;
using eCommerceLayer.Application.Features.Brands.Constants.Languages.TR;
using eCommerceLayer.Application.Features.Brands.DTOs;

namespace eCommerceLayer.Application.Features.Brands.Commands.AddBrand
{
    public class AddBrandDTOValidator : AbstractValidator<BrandAddDTO>
    {
        public AddBrandDTOValidator()
        {
            RuleFor(b => b.BrandName).NotEmpty().WithMessage($"{BrandMessagesTR.Brand} {BaseConstantsTR.Name} {BaseConstantsTR.NotNull}");
            RuleFor(b => b.BrandName).MaximumLength(20).WithMessage($"{BrandMessagesTR.Brand} {BaseConstantsTR.Name} {GeneralConstantsTR.Max30Character}");
        }
    }
}