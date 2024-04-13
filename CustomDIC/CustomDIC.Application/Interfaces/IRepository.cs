namespace CustomDIC.Application.Interfaces
{
    public interface IRepository
    {
        Task<string> GetNameAsync();
    }
}
