using AutoMapper;
using Core.Persistence.Paging;
using eCommerceLayer.Application.Features.Concrete.ProductFeatures.Commands.AddProductFeature;
using eCommerceLayer.Application.Features.Concrete.ProductFeatures.Commands.DeleteProductFeature;
using eCommerceLayer.Application.Features.Concrete.ProductFeatures.Commands.UpdateProductFeature;
using eCommerceLayer.Application.Features.Concrete.ProductFeatures.DTOs;
using eCommerceLayer.Application.Features.Concrete.ProductFeatures.Model;
using eCommerceLayer.Application.Features.Concrete.ProductFeatures.Queries.GetByIdProductFeature;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.ProductFeatures.Profiles
{
    public class ProductFeatureProfiles : Profile
    {
        public ProductFeatureProfiles()
        {
            CreateMap<ProductFeature, ProductFeatureAddDTO>().ReverseMap();
            CreateMap<ProductFeature, ProductFeatureAddCommand>().ReverseMap();

            CreateMap<ProductFeature, ProductFeatureDeleteDTO>().ReverseMap();
            CreateMap<ProductFeature, ProductFeatureDeleteCommand>().ReverseMap();

            CreateMap<ProductFeature, ProductFeatureUpdateDTO>().ReverseMap();
            CreateMap<ProductFeature, ProductFeatureUpdateCommand>().ReverseMap();

            CreateMap<IPaginate<ProductFeature>, ProductFeatureListModel>().ReverseMap();
            CreateMap<ProductFeature, ProductFeatureListDTO>().ReverseMap();

            CreateMap<ProductFeature, ProductFeatureGetByIdDTO>().ReverseMap();
            CreateMap<ProductFeature, GetByIdProductFeatureQuery>().ReverseMap();
        }
    }
}