using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using BlazorClient.Security;

namespace BlazorClient
{
 
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

           // builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            // We register a named HttpClient here for the API
            //builder.Services.AddHttpClient("api")
            //    .AddHttpMessageHandler(sp =>
            //    {
            //        var handler = sp.GetService<AuthorizationMessageHandler>()
            //            .ConfigureHandler(
            //                authorizedUrls: new[] { "https://localhost:5002"  },
            //                scopes: new[] { "weatherapi" });
            //        return handler;
            //    });

            builder.Services.AddScoped<CustomAuthorizationMessageHandler>();

            builder.Services.AddHttpClient("api",
                    client => client.BaseAddress = new Uri("https://localhost:5002"))
                .AddHttpMessageHandler<CustomAuthorizationMessageHandler>();



            // we use the api client as default HttpClient
            builder.Services.AddScoped(
              sp => sp.GetService<IHttpClientFactory>().CreateClient("api"));


            builder.Services
               .AddOidcAuthentication(options =>
               {
                   builder.Configuration.Bind("oidc", options.ProviderOptions);
                   options.UserOptions.RoleClaim = "role";
               })
               .AddAccountClaimsPrincipalFactory<ArrayClaimsPrincipalFactory<RemoteUserAccount>>();


            await builder.Build().RunAsync();
        }
    }
}
