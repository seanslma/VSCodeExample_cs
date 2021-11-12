using Microsoft.Extensions.Configuration;

namespace vsctest
{
    public static class Config
    {
        public static string Name { get; set; }
        public static ClientConfig client;

        public static SampleObj sampleObj;

        static Config()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json").Build();

            Name = config.GetValue<string>("Name");

            var section = config.GetSection(nameof(ClientConfig));
            client = section.Get<ClientConfig>();

            var sect = config.GetSection("SampleObj");
            sampleObj = sect.Get<SampleObj>();

            Console.WriteLine("get config value:");
            Console.WriteLine("By Name: " + config.GetValue<string>("Name"));
            Console.WriteLine("By Sec:Name: " + config.GetSection("SampleObj:PropName").Value);
            Console.WriteLine("By Sec.GetValue: " + config.GetSection("SampleObj").GetValue<string>("PropName"));
        }
    }

    public class ClientConfig
    {
        public bool IsEnabled { get; set; }
        public string APIUrl { get; set; }
        public string Timeout { get; set; }
    }

    public class SampleObj
    {
        public string PropName { get; set; }
    }
}