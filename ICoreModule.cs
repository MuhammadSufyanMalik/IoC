using Microsoft.Extensions.DependencyInjection;

namespace IoC
{
    public interface ICoreModule
    {
        void Load(IServiceCollection serviceCollection);
    }
}
