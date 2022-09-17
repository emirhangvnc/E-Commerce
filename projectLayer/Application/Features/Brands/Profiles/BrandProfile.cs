﻿using AutoMapper;
using Core.Persistence.Paging;
using eCommerceLayer.Application.Features.Brands.DTOs;
using eCommerceLayer.Application.Features.Brands.Models;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Brands.Profiles
{
    public class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<BrandAddDTO, Brand>().ReverseMap();
            CreateMap<BrandDeleteDTO, Brand>().ReverseMap();
            CreateMap<BrandGetByIdDto, Brand>().ReverseMap();
            CreateMap<IPaginate<Brand>, BrandListModel>().ReverseMap();
            CreateMap<BrandDeleteDTO, Brand>().ReverseMap();
        }
    }
}