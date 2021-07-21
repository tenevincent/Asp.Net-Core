using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KE2.ConfigureSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        //public static IHostBuilder CreateHostBuilder(string[] args) =>
        //    Host.CreateDefaultBuilder(args)
        //        .ConfigureWebHostDefaults(webBuilder =>
        //        {
        //            webBuilder.UseStartup<Startup>();
        //        });


        public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.ConfigureAppConfiguration((builderContext, config) =>
                {
                    var env = builderContext.HostingEnvironment;
                    config.SetBasePath(env.ContentRootPath);
                    config.AddJsonFile("appsettings.json",optional: false,reloadOnChange: true);
                    config.AddJsonFile($"appsettings.{env.EnvironmentName}.json",optional: true,reloadOnChange: true);
                    config.AddEnvironmentVariables();



                    config.AddIniFile("appsettings.ini",optional: false,reloadOnChange: true);
                    config.AddJsonFile($"appsettings.{env.EnvironmentName}.ini",optional: true,reloadOnChange: true);


                }).UseStartup<Startup>();
            });



    }
}
