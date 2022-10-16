﻿using eCommerceLayer.Application.Features.Base.Abstract;
using eCommerceLayer.Application.Features.Concrete.Products.DTOs;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.Products.Queries.GetByProductId
{
    public interface IGetByProductIdQuery : IGetByIDService<Product, ProductGetByIdDto>
    {
    }
}