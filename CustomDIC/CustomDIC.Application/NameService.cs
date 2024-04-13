using CustomDIC.Application.Interfaces;
using CustomDIC.Application.Interfaces.Infrastructure;
using CustomDIC.Core.Dependency.Attributes;

namespace CustomDIC.Application
{
    [Transient]
    public class NameService : INameService
    {
        private readonly IRepository _repository;
        private readonly IExternalService _externalService;

        public NameService(IRepository repository,
                           IExternalService externalService)
        {
            _repository = repository;
            _externalService = externalService;
        }
        public async Task<string> GetNameAsync()
        {
            var externalName = await GetExternalNameAsync();

            return await _repository.GetNameAsync();
        }

        private async Task<string> GetExternalNameAsync()
        {
            return await _externalService.GetExternalNameAsync();
        }
    }
}
