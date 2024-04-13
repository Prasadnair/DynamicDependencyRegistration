using CustomDIC.Application.Interfaces.Infrastructure;
using CustomDIC.Core.Dependency.Attributes;

namespace CustomDIC.Infrastructure
{
    [Scoped]
    public class ExternalService : IExternalService

    {
        public async Task<string> GetExternalNameAsync()
        {
            throw new NotImplementedException();
        }
    }
}
