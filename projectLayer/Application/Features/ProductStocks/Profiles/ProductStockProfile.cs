using AutoMapper;
using projectLayer.Application.Features.ProductStocks.DTOs;
using projectLayer.Domain.Entities;

namespace projectLayer.Application.Features.ProductStocks.Profiles
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