using Microsoft.Extensions.Configuration;

namespace vsctest
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("\nFrom Cfg");
            Console.WriteLine(Config.Name);
            Console.WriteLine(Config.client.IsEnabled);
            Console.WriteLine(Config.client.APIUrl);    
            Console.WriteLine(Config.client.Timeout);     
            Console.WriteLine(Config.sampleObj.PropName);     
            return 0;
        }
    }
}