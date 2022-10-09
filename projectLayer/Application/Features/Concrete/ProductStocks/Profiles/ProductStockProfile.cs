using AutoMapper;
using eCommerceLayer.Application.Features.Concrete.ProductStocks.DTOs;
using eCommerceLayer.Domain.Entities;
using Core.Persistence.Paging;

namespace eCommerceLayer.Application.Features.Concrete.ProductStocks.Profiles
{
    public class ProductStockProfile : Profile
    {
        public ProductStockProfile()
        {
            CreateMap<ProductStockAddDTO, ProductStock>().ReverseMap();
            CreateMap<ProductStockUpdateDTO, ProductStock>().ReverseMap();
            CreateMap<ProductStockDeleteDTO, ProductStock>().ReverseMap();
            CreateMap<ProductStockGetByIdDto, ProductStock>().ReverseMap();
            CreateMap<IPaginate<ProductStockListDTO>, ProductStock>().ReverseMap();
        }
    }
}