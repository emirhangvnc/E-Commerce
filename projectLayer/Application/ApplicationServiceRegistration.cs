using Core.Application.Pipelines.Validation;
using eCommerceLayer.Application.Features.Concrete.Brands.Rules;
using eCommerceLayer.Application.Features.Concrete.Categories.Rules;
using eCommerceLayer.Application.Features.Concrete.Cities.Rules;
using eCommerceLayer.Application.Features.Concrete.Countries.Rules;
using eCommerceLayer.Application.Features.Concrete.Features.Rules;
using eCommerceLayer.Application.Features.Concrete.FeatureValues.Rules;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace eCommerceLayer.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());

            services.AddScoped<IBrandBusinessRules, BrandBusinessRules>();
            services.AddScoped<ICategoryBusinessRules, CategoryBusinessRules>();
            services.AddScoped<ICityBusinessRules, CityBusinessRules>();
            services.AddScoped<ICountryBusinessRules, CountryBusinessRules>();
            services.AddScoped<IFeatureBusinessRules, FeatureBusinessRules>();
            services.AddScoped<IFeatureValueBusinessRules, FeatureValueBusinessRules>();

            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(AuthorizationBehavior<,>));
            //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(CachingBehavior<,>));
            //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(CacheRemovingBehavior<,>));
            //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));


            return services;
        }
    }
}