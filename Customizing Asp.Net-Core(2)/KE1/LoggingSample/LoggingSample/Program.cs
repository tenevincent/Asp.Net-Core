using KE1.LoggingSample.Logger;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NLog.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KE1.LoggingSample
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
                webBuilder.ConfigureLogging((hostingContext, logging) =>
                {


                    logging.ClearProviders();
                    logging.SetMinimumLevel(LogLevel.Trace);


                    // ConfigureCustomLogger(logging);
                })
                .UseNLog()
                .UseStartup<Startup>();
            });

        private static void ConfigureCustomLogger(ILoggingBuilder logging)
        {
            logging.ClearProviders();
            var config = new ColoredConsoleLoggerConfiguration
            {
                LogLevel = LogLevel.Information,
                Color = ConsoleColor.Red
            };
            logging.AddProvider(new
            ColoredConsoleLoggerProvider(config));
        }
    }
}
