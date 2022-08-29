using AutoMapper;
using projectLayer.Application.Features.Brands.DTOs;
using projectLayer.Domain.Entities;

namespace projectLayer.Application.Features.Brands.Profiles
{
    public class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<BrandAddDTO, Brand>().ReverseMap();
            CreateMap<BrandUpdateDTO, Brand>().ReverseMap();
            CreateMap<BrandDeleteDTO, Brand>().ReverseMap();
        }
    }
}