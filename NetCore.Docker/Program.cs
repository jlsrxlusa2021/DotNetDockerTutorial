using System;
using System.Threading.Tasks;

//Following tutorial from here:
//  https://docs.microsoft.com/en-us/dotnet/core/docker/build-container

namespace NetCore.Docker
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var counter = 0;
            var max = (args.Length != 0) ? Convert.ToInt32(args[0]) : -1;
            while (max == -1 || counter < max)
            {
                Console.WriteLine($"Counter: {++counter}");
                await Task.Delay(TimeSpan.FromSeconds(1));
            }
            
            Console.WriteLine("\nApplication complete - press any key to exit...");
            _ = Console.ReadKey();
        }
    }
}
