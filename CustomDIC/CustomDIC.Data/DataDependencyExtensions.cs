using CustomDIC.Core.Dependency.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace CustomDIC.Data
{
    public static class DataDependencyExtensions
    {
        public static void AddDataDependencies(this IServiceCollection services)
        {
            services.RegisterInterfacesAndImplementations("CustomDIC.Application", "CustomDIC.Data");
            
        }
    }
}
