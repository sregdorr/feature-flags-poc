using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alcoms.Config;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace FeatureFlag.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder
                        .ConfigureAppConfiguration((hostingContext, config) =>
                        {
                            var environment = hostingContext.HostingEnvironment.EnvironmentName;
                            config.AddJsonFile("appsettings.json");
                            config.AddJsonFile($"appsettings.{environment}.json");
                            config.AddEnvironmentVariables();
                            config.AddAlcomsConfig("TestApp", "staging");
                        })
                        .UseStartup<Startup>();
                });
    }
}
