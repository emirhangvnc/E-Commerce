using Autofac;
using projectLayer.Application.Features.Categories.Rules;
using projectLayer.Application.Services.Abstract;
using projectLayer.Application.Services.Repositories;
using projectLayer.Persistence.Repositories;

namespace projectLayer.Application.Services.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            builder.RegisterType<CategoryRepository>().As<ICategoryRepository>().SingleInstance();

            //builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            //builder.RegisterType<CategoryRepository>().As<ICategoryRepository>().SingleInstance();

            //builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            //builder.RegisterType<CategoryRepository>().As<ICategoryRepository>().SingleInstance();

            //builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            //builder.RegisterType<CategoryRepository>().As<ICategoryRepository>().SingleInstance();
        }
    }
}