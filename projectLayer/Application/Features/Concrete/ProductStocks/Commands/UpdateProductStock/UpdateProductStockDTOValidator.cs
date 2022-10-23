﻿using FluentValidation;
using eCommerceLayer.Application.Features.Base.Constants.Languages.TR.Base;
using eCommerceLayer.Application.Features.Concrete.Products.Constants.Languages.TR;
using eCommerceLayer.Application.Features.Concrete.ProductStocks.Constants.Languages.TR;
using eCommerceLayer.Application.Features.Concrete.ProductStocks.DTOs;

namespace eCommerceLayer.Application.Features.Concrete.ProductStocks.Commands.UpdateProductStock
{
    public class UpdateProductStockDTOValidator : AbstractValidator<ProductStockUpdateDTO>
    {
        public UpdateProductStockDTOValidator()
        {
            RuleFor(p => p.ProductId).NotEmpty().WithMessage($"{ProductMessagesTR.Product} {BaseConstantsTR.ID} {BaseConstantsTR.NotNull}");
            RuleFor(p => p.UnitStock).NotEmpty().WithMessage($"{ProductStockMessagesTR.ProductStock} Değeri {BaseConstantsTR.NotNull}");
        }
    }
}