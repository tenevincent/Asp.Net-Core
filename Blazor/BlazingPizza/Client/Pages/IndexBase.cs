using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazingPizza.Shared.Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace BlazingPizza.Client.Pages
{
    public class IndexBase : ComponentBase
    {
        protected List<PizzaSpecial> specials;

        [Inject]
        public HttpClient HttpClient{ get; set; }

        protected override async Task OnInitializedAsync()
        {
            specials = await HttpClient.GetFromJsonAsync<List<PizzaSpecial>>("specials");
        }
    }
}
