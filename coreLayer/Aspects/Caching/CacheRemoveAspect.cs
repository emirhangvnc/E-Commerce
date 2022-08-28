using Castle.DynamicProxy;
using coreLayer.CCC.Caching;
using coreLayer.Utilities.Interceptors;
using coreLayer.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace coreLayer.Aspects.Caching
{
    public class CacheRemoveAspect : MethodInterception
    {
        private string _pattern;
        private ICacheManager _cacheManager;

        public CacheRemoveAspect(string pattern)
        {
            _pattern = pattern;
            _cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();
        }

        protected override void OnSuccess(IInvocation invocation)
        {
            _cacheManager.RemoveByPattern(_pattern);
        }
    }
}