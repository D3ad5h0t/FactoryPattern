using System;
using System.Threading.Tasks;

namespace AsyncFactory
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var foo = AsyncFactory.Create<Foo>();
        }
    }
}