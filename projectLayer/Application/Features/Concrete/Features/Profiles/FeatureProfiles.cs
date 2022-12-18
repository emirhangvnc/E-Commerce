using AutoMapper;
using eCommerceLayer.Application.Features.Concrete.Features.Commands.AddFeature;
using eCommerceLayer.Application.Features.Concrete.Features.DTOs;
using eCommerceLayer.Domain.Entities;

namespace eCommerceLayer.Application.Features.Concrete.Features.Profiles
{
    public class FeatureProfiles : Profile
    {
        public FeatureProfiles()
        {
            CreateMap<Feature, FeatureAddDTO>().ReverseMap();
            CreateMap<Feature, FeatureAddCommand>().ReverseMap();
        }
    }
}