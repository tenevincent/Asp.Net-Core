using ArticleManager.Client.Models;
using ArticleManager.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ArticleManager.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddHttpClient("ArticleManager.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
                .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

            // Supply HttpClient instances that include access tokens when making requests to the server project
            builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("ArticleManager.ServerAPI"));

            builder.Services.AddTransient<ICRUDService<ArticleCategoryListItem, ArticleCategoryItem>, ArticleCategoriesService>();
            builder.Services.AddTransient<ICRUDService<ArticleListItem, ArticleItem>, ArticlesService>();


            builder.Services.AddApiAuthorization();

            await builder.Build().RunAsync();
        }
    }
}
