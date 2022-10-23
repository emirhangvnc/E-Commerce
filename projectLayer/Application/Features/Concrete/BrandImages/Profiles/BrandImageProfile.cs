using AutoMapper;
using Core.Persistence.Paging;
using eCommerceLayer.Application.Features.Concrete.BrandImages.DTOs;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.BrandImages.Profiles
{
    public class BrandImageProfile : Profile
    {
        public BrandImageProfile()
        {
            CreateMap<BrandImageUploadDTO, Brand>().ReverseMap();
            CreateMap<BrandImageUpdateDTO, Brand>().ReverseMap();
        }
    }
}