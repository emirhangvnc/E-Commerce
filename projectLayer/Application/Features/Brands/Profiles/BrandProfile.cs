using AutoMapper;
using Core.Persistence.Paging;
using projectLayer.Application.Features.Brands.DTOs;
using projectLayer.Application.Features.Brands.Models;
using projectLayer.Domain.Entities;

namespace projectLayer.Application.Features.Brands.Profiles
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