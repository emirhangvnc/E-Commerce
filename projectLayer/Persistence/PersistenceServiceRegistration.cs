using Microsoft.Extensions.DependencyInjection;
using eCommerceLayer.Persistence.Contexts;
using eCommerceLayer.Persistence.Repositories;
using eCommerceLayer.Persistence.Services.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace eCommerceLayer.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services,
                                                                IConfiguration configuration)
        {
            services.AddDbContext<BaseDbContext>(options =>
                                                     options.UseSqlServer(
                                                         configuration.GetConnectionString("ECommerceConnectionString")));
            services.AddScoped<IBrandImageRepository, BrandImageRepository>();
            services.AddScoped<IBrandRepository, BrandRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IFavoriteRepository, FavoriteRepository>();
            services.AddScoped<IFeatureRepository, FeatureRepository>();
            services.AddScoped<IFeatureValueRepository, FeatureValueRepository>();
            services.AddScoped<IProductBrandRepository, ProductBrandRepository>();
            services.AddScoped<IProductCategoryRepository, ProductCategoryRepository>();
            services.AddScoped<IProductFeatureRepository, ProductFeatureRepository>();
            services.AddScoped<IProductImageRepository, ProductImageRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductStockRepository, ProductStockRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}