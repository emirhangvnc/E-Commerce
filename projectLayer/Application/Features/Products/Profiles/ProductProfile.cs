using AutoMapper;
using projectLayer.Application.Features.Products.DTOs;
using projectLayer.Domain.Entities;

namespace projectLayer.Application.Features.Products.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductAddDTO, Product>().ReverseMap();
            CreateMap<ProductUpdateDTO, Product>().ReverseMap();
            CreateMap<ProductDeleteDTO, Product>().ReverseMap();
        }
    }
}