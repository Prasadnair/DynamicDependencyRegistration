namespace CustomDIC.Application
{
    public interface INameService
    {
        Task<string> GetNameAsync();
    }
}
