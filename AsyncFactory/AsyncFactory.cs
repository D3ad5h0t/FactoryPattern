using System.Threading.Tasks;

namespace AsyncFactory
{
    public static class AsyncFactory
    {
        public static async Task<T> Create<T>() where T : IAsyncInit<T>, new() => await new T().InitAsync();
    }
}