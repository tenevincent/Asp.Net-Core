using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace KEB11.HostBuilderConfig
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureLogging((context, config) =>
                {
                    var logLevel = context.Configuration.GetValue("Logging:LogLevel", "");

                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder
                        .UseKestrel((host, options) =>
                        {
                            var filename = host.Configuration.GetValue("AppSettings:certfilename", "");
                            var password = host.Configuration.GetValue("AppSettings:certpassword", "");
                            options.Listen(IPAddress.Loopback, 5000);
                            options.Listen(IPAddress.Loopback, 5001, listenOptions =>
                            {
                                listenOptions.UseHttps(filename, password);
                            });
                        })
                        .UseStartup<Startup>();
                });
    }





    //public static void Main(string[] args)
    //{
    //    CreateHostBuilder(args).Build().Run();
    //}

    //public static IHostBuilder CreateHostBuilder(string[] args) =>
    //    Host.CreateDefaultBuilder(args)
    //        .ConfigureWebHostDefaults(webBuilder =>
    //        {
    //            webBuilder.UseStartup<Startup>();
    //        });


}
