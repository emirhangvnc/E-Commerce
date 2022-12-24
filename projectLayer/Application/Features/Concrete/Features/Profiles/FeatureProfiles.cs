using AutoMapper;
using Core.Persistence.Paging;
using eCommerceLayer.Application.Features.Concrete.Features.Commands.AddFeature;
using eCommerceLayer.Application.Features.Concrete.Features.Commands.DeleteFeature;
using eCommerceLayer.Application.Features.Concrete.Features.Commands.UpdateFeature;
using eCommerceLayer.Application.Features.Concrete.Features.DTOs;
using eCommerceLayer.Application.Features.Concrete.Features.Model;
using eCommerceLayer.Application.Features.Concrete.Features.Queries.GetAllFeatures;
using eCommerceLayer.Application.Features.Concrete.Features.Queries.GetByIdFeatures;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.Features.Profiles
{
    public class FeatureProfiles : Profile
    {
        public FeatureProfiles()
        {
            CreateMap<Feature, FeatureAddDTO>().ReverseMap();
            CreateMap<Feature, FeatureAddCommand>().ReverseMap();

            CreateMap<Feature, FeatureDeleteDTO>().ReverseMap();
            CreateMap<Feature, FeatureDeleteCommand>().ReverseMap();

            CreateMap<Feature, FeatureUpdateDTO>().ReverseMap();
            CreateMap<Feature, FeatureUpdateCommand>().ReverseMap();

            CreateMap<IPaginate<Feature>, FeatureListModel>().ReverseMap();
            CreateMap<Feature, FeatureListDTO>().ReverseMap();
            CreateMap<Feature, GetListFeatureQuery>().ReverseMap();
            CreateMap<Feature, FeatureGetByIdDTO>().ReverseMap();
            CreateMap<Feature, GetByIdFeaturesQuery>().ReverseMap();
        }
    }
}