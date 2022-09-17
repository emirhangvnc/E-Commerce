using AutoMapper;
using eCommerceLayer.Application.Features.ProductStocks.DTOs;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.ProductStocks.Profiles
{
    public class ProductStockProfile : Profile
    {
        public ProductStockProfile()
        {
            CreateMap<ProductStockAddDTO, ProductStock>().ReverseMap();
            CreateMap<ProductStockUpdateDTO, ProductStock>().ReverseMap();
            CreateMap<ProductStockDeleteDTO, ProductStock>().ReverseMap();
        }
    }
}