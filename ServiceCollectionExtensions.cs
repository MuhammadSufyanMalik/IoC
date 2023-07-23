using Microsoft.Extensions.DependencyInjection;

namespace IoC

{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencyResolvers(this IServiceCollection services, ICoreModule[] modules)
        {
            foreach (ICoreModule coreModule in modules)
            {
                coreModule.Load(services);
            }

            return ServiceTool.Create(services);
        }
    }
}
