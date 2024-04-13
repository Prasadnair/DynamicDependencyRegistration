using CustomDIC.Application.Interfaces;
using CustomDIC.Core.Dependency.Attributes;

namespace CustomDIC.Data
{
    [Scoped]
    public class Repository : IRepository
    {
        public async Task<string> GetNameAsync()
        {
            throw new NotImplementedException();
        }
    }
}
