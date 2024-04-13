using CustomDIC.Core.Dependency.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace CustomDIC.Infrastructure
{
    public static class InfrastructureDepedencyExtensions
    {
        public static void AddInfrastructureDependencies(this IServiceCollection services)
        {
            services.RegisterInterfacesAndImplementations("CustomDIC.Application", "CustomDIC.Infrastructure");
        }
    }
}
