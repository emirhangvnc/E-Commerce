using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace projectLayer.Application.Services.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<CityManager>().As<ICityService>().SingleInstance();
            //builder.RegisterType<EfCityDal>().As<ICityDal>().SingleInstance();

            //builder.RegisterType<AuthManager>().As<IAuthService>().SingleInstance();
            //builder.RegisterType<JwtHelper>().As<ITokenHelper>().SingleInstance();
        }
    }
}