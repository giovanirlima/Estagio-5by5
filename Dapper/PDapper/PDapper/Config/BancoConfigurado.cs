using System.IO;
using Microsoft.Extensions.Configuration;

namespace PDapper.Config
{
    public class BancoConfigurado
    {
        public static IConfigurationRoot Configuration { get; set; }

        public static string Get()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetings.json", optional: true, reloadOnChange: true);

            Configuration = builder.Build();

            return Configuration["ConnectionStrings:DefaultConnection"];            
        }
    }
}
