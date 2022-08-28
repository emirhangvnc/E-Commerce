using Microsoft.Extensions.DependencyInjection;

namespace coreLayer.Utilities.IoC
{
    public interface ICoreModule
    {
        void Load(IServiceCollection collection);
    }
}