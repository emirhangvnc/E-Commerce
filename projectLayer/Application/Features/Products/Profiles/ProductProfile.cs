using AutoMapper;
using eCommerceLayer.Application.Features.Products.DTOs;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Products.Profiles
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