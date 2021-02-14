#pragma checksum "C:\DevGit\Asp.Net Core\Blazor\BlazingPizza\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f33a5ccf93905938d76bb8366cb29e01cd0bee7b"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazingPizza.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\DevGit\Asp.Net Core\Blazor\BlazingPizza\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\DevGit\Asp.Net Core\Blazor\BlazingPizza\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\DevGit\Asp.Net Core\Blazor\BlazingPizza\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\DevGit\Asp.Net Core\Blazor\BlazingPizza\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\DevGit\Asp.Net Core\Blazor\BlazingPizza\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\DevGit\Asp.Net Core\Blazor\BlazingPizza\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\DevGit\Asp.Net Core\Blazor\BlazingPizza\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\DevGit\Asp.Net Core\Blazor\BlazingPizza\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\DevGit\Asp.Net Core\Blazor\BlazingPizza\Client\_Imports.razor"
using BlazingPizza.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\DevGit\Asp.Net Core\Blazor\BlazingPizza\Client\_Imports.razor"
using BlazingPizza.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\DevGit\Asp.Net Core\Blazor\BlazingPizza\Client\_Imports.razor"
using BlazingPizza.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : IndexBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Blazing Pizzas</h1>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "main");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "ul");
            __builder.AddAttribute(5, "class", "pizza-cards");
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 11 "C:\DevGit\Asp.Net Core\Blazor\BlazingPizza\Client\Pages\Index.razor"
         if (specials != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\DevGit\Asp.Net Core\Blazor\BlazingPizza\Client\Pages\Index.razor"
             foreach (var special in specials)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "                ");
            __builder.OpenElement(8, "li");
            __builder.AddAttribute(9, "style", "background-image:" + " url(\'" + (
#nullable restore
#line 15 "C:\DevGit\Asp.Net Core\Blazor\BlazingPizza\Client\Pages\Index.razor"
                                                   special.ImageUrl

#line default
#line hidden
#nullable disable
            ) + "\')");
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "pizza-info");
            __builder.AddMarkupContent(13, "\r\n                        ");
            __builder.OpenElement(14, "span");
            __builder.AddAttribute(15, "class", "title");
            __builder.AddContent(16, 
#nullable restore
#line 17 "C:\DevGit\Asp.Net Core\Blazor\BlazingPizza\Client\Pages\Index.razor"
                                             special.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                        ");
            __builder.AddContent(18, 
#nullable restore
#line 18 "C:\DevGit\Asp.Net Core\Blazor\BlazingPizza\Client\Pages\Index.razor"
                         special.Description

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(19, "\r\n                        ");
            __builder.OpenElement(20, "span");
            __builder.AddAttribute(21, "class", "price");
            __builder.AddContent(22, 
#nullable restore
#line 19 "C:\DevGit\Asp.Net Core\Blazor\BlazingPizza\Client\Pages\Index.razor"
                                             special.GetFormattedBasePrice()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
#nullable restore
#line 22 "C:\DevGit\Asp.Net Core\Blazor\BlazingPizza\Client\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\DevGit\Asp.Net Core\Blazor\BlazingPizza\Client\Pages\Index.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
