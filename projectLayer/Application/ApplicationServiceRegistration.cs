﻿using eCommerceLayer.Application.Features.Concrete.Brands.Rules;
using Core.Application.Pipelines.Validation;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using eCommerceLayer.Application.Features.Concrete.Categories.Rules;
using Core.Application.Pipelines.Authorization;
using Core.Application.Pipelines.Caching;
using Core.Application.Pipelines.Logging;
using eCommerceLayer.Application.Features.Concrete.Brands.Commands.DeleteBrand;
using eCommerceLayer.Application.Features.Concrete.Brands.Commands.UpdateBrand;
using eCommerceLayer.Application.Features.Concrete.Brands.Commands.AddBrand;
using eCommerceLayer.Application.Features.Concrete.Brands.Commands.CreateBrand;
using eCommerceLayer.Application.Features.Concrete.Brands.Queries.GetAllBrand;
using eCommerceLayer.Application.Features.Concrete.Brands.Queries.GetByIdBrand;
using eCommerceLayer.Application.Features.Concrete.Categories.Commands.AddCategory;
using eCommerceLayer.Application.Features.Concrete.Categories.Commands.DeleteCategory;
using eCommerceLayer.Application.Features.Concrete.Categories.Commands.UpdateCategory;
using eCommerceLayer.Application.Features.Concrete.Categories.Queries.GetListBrand;
using eCommerceLayer.Application.Features.Concrete.Categories.Queries.GetByIdCategory;

namespace eCommerceLayer.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            //services.AddMediatR(Assembly.GetExecutingAssembly());

            #region Brand

            #region Commands
            services.AddScoped<IAddBrandService, AddBrandCommand>();
            services.AddScoped<IDeleteBrandService, DeleteBrandCommand>();
            services.AddScoped<IUpdateBrandService, UpdateBrandCommand>();
            #endregion

            #region Queries
            services.AddScoped<IGetAllBrandQuery, GetAllBrandQuery>();
            services.AddScoped<IGetByIdBrandQuery, GetByIdBrandQuery>();
            #endregion

            #region Rules
            services.AddScoped<IBrandBusinessRules, BrandBusinessRules>();
            #endregion

            #endregion

            #region Category

            #region Commands
            services.AddScoped<IAddCategoryService, AddCategoryCommand>();
            services.AddScoped<IDeleteCategoryService, DeleteCategoryCommand>();
            services.AddScoped<IUpdateCategoryService, UpdateCategoryCommand>();
            #endregion

            #region Queries
            services.AddScoped<IGetAllCategoryQuery, GetAllCategoryQuery>();
            services.AddScoped<IGetByIdCategoryQuery, GetByIdCategoryQuery>();
            #endregion

            #region Rules
            services.AddScoped<ICategoryBusinessRules, CategoryBusinessRules>();
            #endregion

            #endregion

            #region Template

            #region Commands
            //services.AddScoped<IAddTemplateService, AddTemplateCommand>();
            #endregion

            #region Queries
            //services.AddScoped<IGetAllTemplateQuery, GetAllTemplateQuery>();
            #endregion

            #region Rules
            //services.AddScoped<ITemplateBusinessRules, TemplateBusinessRules>();
            #endregion

            #endregion



            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(AuthorizationBehavior<,>));
            //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(CachingBehavior<,>));
            //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(CacheRemovingBehavior<,>));
            //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>));
            //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));

            return services;
        }
    }
}