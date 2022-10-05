﻿using eCommerceLayer.Application.Features.Base.Abstract;
using eCommerceLayer.Application.Features.Concrete.Brands.DTOs;

namespace eCommerceLayer.Application.Features.Concrete.Brands.Commands.DeleteBrand
{
    public interface IDeleteBrandService: IDeleteService<BrandDeleteDTO>
    {
    }
}