using CustomDIC.Core.Dependency.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace CustomDIC.Application
{
    public static class ApplicationDependencyExtensions
    {
        public static void AddApplicationDependencies(this IServiceCollection services)
        {
            services.RegisterInterfacesAndImplementations("CustomDIC.Application", "CustomDIC.Application");
        }

    }
}
